using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using TaskProgresser.Core.Models;

namespace TaskProgresser.WinForms.ApiClients
{
    public class TasksApiClient : BaseApiClient
    {

        //Get All
        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            return await Client.GetFromJsonAsync<List<TaskItem>>($"{BaseUrl}/tasks") ?? new List<TaskItem>();
        }

        //Get by Id
        public async Task<TaskItem> GetTaskById(Guid id)
        {
            return await Client.GetFromJsonAsync<TaskItem>($"{BaseUrl}/tasks/{id}") ?? new TaskItem();
        }

        //Post (Create)
        public async Task<TaskItem> AddTaskAsync(TaskItem newTask)
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync($"{BaseUrl}/tasks", newTask);
            if (response != null && response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<TaskItem>();

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Помилка при додаванні завдання: {response.StatusCode} - {message}");
        }

        //Put (Update)
        public async Task<TaskItem> UpdateTaskAsync(TaskItem updatedTask)
        {
            Guid id = updatedTask.Id;
            HttpResponseMessage response = await Client.PutAsJsonAsync($"{BaseUrl}/tasks/{id}", updatedTask);
            
            if (response != null && response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<TaskItem>();
   
            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Помилка при оновленні завдання ({response.StatusCode}): - {message}");
        }

        //Delete
        public async Task DeleteTaskAsync(Guid id)
        {
            HttpResponseMessage response = await Client.DeleteAsync($"{BaseUrl}/tasks/{id}");
            
            if (response != null && response.IsSuccessStatusCode) return;

            var message = await response.Content.ReadAsStringAsync();
            throw new Exception($"Помилка при видаленні завдання ({response.StatusCode}): - {message}");
        }      
    }
}