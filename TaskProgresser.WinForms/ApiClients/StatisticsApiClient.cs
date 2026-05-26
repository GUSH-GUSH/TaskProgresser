using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.DTOs;

namespace TaskProgresser.WinForms.ApiClients
{
    public class StatisticsApiClient : BaseApiClient
    {
        public async Task<TaskStatisticsDto> GetStatistics()
        {
            return await Client.GetFromJsonAsync<TaskStatisticsDto>($"{BaseUrl}/statistics") ?? new TaskStatisticsDto();
        }
    }
}