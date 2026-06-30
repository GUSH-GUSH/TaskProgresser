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
        private static readonly string StatisticsEndPoint = $"{BaseUrl}/statistics";

        public async Task<TaskStatisticsDto> GetStatistics()
        {
            var response = await Client.GetAsync(StatisticsEndPoint);
            EnsureValidResponse(response);
            return await response.Content.ReadFromJsonAsync<TaskStatisticsDto>() ?? new TaskStatisticsDto();
        }
    }
}