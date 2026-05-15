using System.Text.Json;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;

namespace TaskProgresser.Api.Services
{
    public class JsonTaskService
    {
        private readonly string _filePath = "tasks.json";

        public async Task SaveTaskAsync(TaskItem newTask)
        {
            List<TaskItem> tasks = await GetAllTasksAsync();

            tasks.Add(newTask);

            string jsonString = TaskConverter.ToJson(newTask);

            await File.WriteAllTextAsync(_filePath, jsonString);
        }

        public async Task SaveAllTasksAsync(List<TaskItem> tasks)
        {

            var options = new JsonSerializerOptions { WriteIndented = true };

            string jsonString = TaskConverter.ToJson(tasks);

            await File.WriteAllTextAsync(_filePath, jsonString);
        }

        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            if (!File.Exists(_filePath)) return new List<TaskItem>();

            string jsonString = await File.ReadAllTextAsync(_filePath);

            if (string.IsNullOrWhiteSpace(jsonString)) return new List<TaskItem>();

            return TaskConverter.FromJsonArray(jsonString) ?? new List<TaskItem>();
        }
    }
}