using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using TaskProgresser.Core.Models;
using System.Linq;

namespace TaskProgresser.WinForms.ApiClients
{
    public class TasksApiClient : BaseApiClient
    {
        private static readonly string TasksEndPoint = $"{BaseUrl}/tasks";

        //Get All
        public async Task<List<TaskItem>> GetAllTasksAsync()
        {
            var response = await Client.GetAsync(TasksEndPoint);
            EnsureValidResponse(response);
            return (await response.Content.ReadFromJsonAsync<List<TaskItem>> ()).Select(t=>t.ToLocalTime()).ToList() ?? new List<TaskItem>();
        }

        //Get by Id
        public async Task<TaskItem> GetTaskById(Guid id)
        {
            var response = await Client.GetAsync($"{TasksEndPoint}/{id}");      
            EnsureValidResponse(response);
            return (await response.Content.ReadFromJsonAsync<TaskItem>()).ToLocalTime() ?? new TaskItem();
        }

        //Post (Create)
        public async Task<TaskItem> AddTaskAsync(TaskItem newTask)
        {
            HttpResponseMessage response = await Client.PostAsJsonAsync(TasksEndPoint, newTask.ToUTC());
            EnsureValidResponse(response);
            return await response.Content.ReadFromJsonAsync<TaskItem>();
        }

        //Put (Update)
        public async Task<TaskItem> UpdateTaskAsync(TaskItem updatedTask)
        {
            Guid id = updatedTask.Id;
            HttpResponseMessage response = await Client.PutAsJsonAsync($"{TasksEndPoint}/{id}", updatedTask.ToUTC());
            EnsureValidResponse(response);
            return await response.Content.ReadFromJsonAsync<TaskItem>();
        }

        //Delete
        public async Task DeleteTaskAsync(Guid id)
        {
            HttpResponseMessage response = await Client.DeleteAsync($"{TasksEndPoint}/{id}");
            EnsureValidResponse(response);
        }
    }
}