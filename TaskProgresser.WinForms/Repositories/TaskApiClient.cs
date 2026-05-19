using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TaskProgresser.Core.Models;

namespace TaskProgresser.WinForms.Services
{
    public static class TaskApiClient
    {
        private static readonly HttpClient _client = new HttpClient();
        private static readonly string _baseUrl = "https://localhost:7239/api/tasks";

        public static async Task<List<TaskItem>> GetAllTasksAsync()
        {
            try
            {
                return await _client.GetFromJsonAsync<List<TaskItem>>(_baseUrl) ?? new List<TaskItem>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка GET: {ex.Message}");
                return new List<TaskItem>();
            }
        }

        public static async Task<bool> AddTaskAsync(TaskItem newTask)
        {
            try
            {
                HttpResponseMessage response = await _client.PostAsJsonAsync(_baseUrl, newTask);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка POST: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> SaveAllData(IEnumerable<TaskItem> tasks)
        {
            try
            {
                HttpResponseMessage response = await _client.PostAsJsonAsync($"{_baseUrl}/bulk", tasks);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка BULK POST: {ex.Message}");
                return false;
            }
        }
    }
}