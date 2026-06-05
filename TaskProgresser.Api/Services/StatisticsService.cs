using Microsoft.EntityFrameworkCore;
using TaskProgresser.Core.DTOs;
using TaskProgresser.Core.Services;
using TaskProgresser.Api.Data;

namespace TaskProgresser.Api.Services
{
    public class StatisticsService
    {
        private readonly AppDbContext _context;

        public StatisticsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<TaskStatisticsDto> CalculateForUserAsync(Guid userId)
        {
            var tasks = await _context.Tasks
                .Where(t => t.UserId == userId)
                .ToListAsync();

            if (!tasks.Any())
                return new TaskStatisticsDto();

            var now = DateTime.Now;

            return new TaskStatisticsDto
            {
                TotalTasks = tasks.Count,
                ActiveTasks = tasks.Count(t => !t.IsCompleted),
                CompletedTasks = tasks.Count(t => t.IsCompleted),

                NotStarted = tasks.Count(t => !t.IsCompleted && now < t.StartDate),
                InProgress = tasks.Count(t => !t.IsCompleted && now >= t.StartDate && now <= t.EndDate),
                Overdue = tasks.Count(t => !t.IsCompleted && now > t.EndDate),

                CompletedInTime = tasks.Count(t => t.IsCompleted && t.CompletedAt <= t.EndDate),
                CompletedLate = tasks.Count(t => t.IsCompleted && t.CompletedAt > t.EndDate),

                AverageCompletionPercent = Math.Round(tasks
                    .Where(t => t.IsCompleted && t.CompletedAt.HasValue)
                    .Select(t => TaskAnalyticsService.CalculateEfficiency(t))
                    .DefaultIfEmpty(0)
                    .Average(), 2)
            };
        }
    }
}