using Microsoft.AspNetCore.Mvc;
using TaskProgresser.Api.Services;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksFromJsonController : ControllerBase
    {
        private readonly JsonTaskService _taskService;

        public TasksFromJsonController(JsonTaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TaskItem task)
        {
            if (task == null || string.IsNullOrEmpty(task.Title))
            {
                return BadRequest("Данные задачи некорректны");
            }

            await _taskService.SaveTaskAsync(task);

            return CreatedAtAction(nameof(GetAll), new { id = task.Id }, task);
        }

        [HttpPost("bulk")]
        public async Task<IActionResult> Create([FromBody] List<TaskItem> tasks)
        {
            if (tasks == null)
            {
                return BadRequest("Список некорректный");
            }

            await _taskService.SaveAllTasksAsync(tasks);

            return CreatedAtAction(nameof(GetAll), tasks);
        }
    }
}