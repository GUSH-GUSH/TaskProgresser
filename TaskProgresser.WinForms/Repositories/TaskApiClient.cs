using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;

namespace TaskProgresser.WinForms.Services
{
    public static class TaskApiClient
    {
        private static readonly HttpClient _client = new HttpClient();
        private static string _baseUrl = "https://localhost:7239/api/tasks";

        public static async Task<bool> AddTaskAsync(TaskItem newTask)
        {
            try
            {
                string json = JsonSerializer.Serialize(newTask);

                // 2. Упаковываем в "содержимое" для HTTP-запроса
                // Указываем кодировку UTF8 и тип данных application/json
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 3. Отправляем POST запрос
                HttpResponseMessage response = await _client.PostAsync(_baseUrl, content);

                // 4. Проверяем, успешно ли (код 200-299)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при связи с API: {ex.Message}");
                return false;
            }
        }

        public static async Task<bool> SaveAllData(List<TaskItem> tasks)
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks);

                // 2. Упаковываем в "содержимое" для HTTP-запроса
                // Указываем кодировку UTF8 и тип данных application/json
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // 3. Отправляем POST запрос
                HttpResponseMessage response = await _client.PostAsync(_baseUrl+"/bulk", content);

                // 4. Проверяем, успешно ли (код 200-299)
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при связи с API: {ex.Message}");
                return false;
            }
        }


        public static async Task<List<TaskItem>> GetAllTasksAsync()
        {
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_baseUrl);
                string result = await response.Content.ReadAsStringAsync();


                if (response.IsSuccessStatusCode)
                    return TaskConverter.FromJsonArray(result);

                return new List<TaskItem>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении данных API: {ex.Message}");

                return new List<TaskItem>();
            }
        }
    }
}