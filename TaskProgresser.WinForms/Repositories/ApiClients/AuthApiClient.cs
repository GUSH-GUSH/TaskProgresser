using System.Threading.Tasks;
using System.Net.Http.Json;
using TaskProgresser.Core.DTOs;
using System;

namespace TaskProgresser.WinForms.Repositories.ApiClients
{
    public class AuthApiClient : BaseApiClient
    {
        public async Task<string> LoginAsync(string username, string password)
        {
            var response = await Client.PostAsJsonAsync($"{BaseUrl}/auth/login",
                new AuthRequest { Username = username, Password = password });

            if (response.IsSuccessStatusCode)
            {
                var authData = await response.Content.ReadFromJsonAsync<AuthResponse>();

                if (authData != null && !string.IsNullOrWhiteSpace(authData.Token))
                {
                    SetToken(authData.Token);
                    return authData.Token;
                }

                throw new Exception("Не вдалося отримати токен");
            }

            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception($"Помилка входу ({response.StatusCode}) - {errorMessage}");
        }

        public async Task RegisterAsync(string username, string password)
        {
            var response = await Client.PostAsJsonAsync($"{BaseUrl}/auth/register",
                new AuthRequest { Username = username, Password = password });

            if (response.IsSuccessStatusCode) return;

            string errorMessage = await response.Content.ReadAsStringAsync();
            throw new Exception($"Помилка реєстрації ({response.StatusCode}) - {errorMessage}");
        }
    }
}