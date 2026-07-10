using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TaskProgresser.Api.Data;
using TaskProgresser.Core.Models;

namespace TaskProgresser.WinForms.ApiClients
{
    [Authorize] // Захищаємо увесь контролер!
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;

        private const string UNAUTHORIZED_MESSAGE = "Не вдалось визначити користувача з таким токеном!";
        private const string TASK_NOT_FOUND_MESSAGE = "Задачу не знайдено, або у Вас немає до неї доступу!";

        private Guid CurrentUserId
        {
            get
            {
                var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                return Guid.TryParse(userIdString, out Guid id) ? id : Guid.Empty;
            }
        }

        public TasksController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskItem task)
        {
            var userId = CurrentUserId;
            if (userId == Guid.Empty) return Unauthorized(UNAUTHORIZED_MESSAGE);

            task.UserId = userId;

            _context.Tasks.Add(task.ToUTC());
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
        }

        // ОБНОВЛЕНИЕ ЗАДАЧИ (PUT api/tasks/{id})
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] TaskItem updatedTask)
        {
            var userId = CurrentUserId;
            if (userId == Guid.Empty) return Unauthorized(UNAUTHORIZED_MESSAGE);

            var existingTask = await _context.Tasks
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (existingTask == null) return NotFound(TASK_NOT_FOUND_MESSAGE);

            updatedTask.ToUTC();

            // Оновлюємо поля
            existingTask.Title = updatedTask.Title;
            existingTask.Description = updatedTask.Description;
            existingTask.StartDate = updatedTask.StartDate;
            existingTask.EndDate = updatedTask.EndDate;
            existingTask.CompletedAt = updatedTask.CompletedAt;
            existingTask.Precision = updatedTask.Precision;
            existingTask.ShowInTray = updatedTask.ShowInTray;

            await _context.SaveChangesAsync();

            return Ok(existingTask);
        }

        // УДАЛЕНИЕ ЗАДАЧИ (DELETE api/tasks/{id})
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var userId = CurrentUserId;
            if (userId == Guid.Empty) return Unauthorized();

            var task = await _context.Tasks
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);

            if (task == null)
                return NotFound(TASK_NOT_FOUND_MESSAGE);

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return Ok("Задача успішно видалена!");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userId = CurrentUserId;
            if (userId == Guid.Empty) return Unauthorized(UNAUTHORIZED_MESSAGE);

            var tasks = await _context.Tasks
                .Where(t => t.UserId == userId)
                .ToListAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var userId = CurrentUserId;
            if (userId == Guid.Empty) return Unauthorized(UNAUTHORIZED_MESSAGE);

            var task = await _context.Tasks
                .FirstOrDefaultAsync(t => t.Id == id && t.UserId == userId);
 
            if (task == null) return NotFound(TASK_NOT_FOUND_MESSAGE);
 
            return Ok(task);
        }
    }
}