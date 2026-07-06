using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Principal;
using System.Windows;
using TaskProgresser.WinForms.Properties;
using TaskProgresser.Core.Services;

namespace TaskProgresser.WinForms.ApiClients
{
    public abstract class BaseApiClient
    {
        protected static readonly HttpClient Client = new HttpClient();

        #if DEBUG
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrlDebug;
        #else
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrl;
        #endif

        public static string Token { get; private set; }

        public static event Action<string> OnUnathorized;

        public BaseApiClient()
        {
            if (!string.IsNullOrWhiteSpace(Settings.Default.ApiToken))
                SetToken(Settings.Default.ApiToken);
        }

        public void SetToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Token cannot be null or empty.", nameof(token));
            Token = token;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Settings.Default.ApiToken = token;
            Settings.Default.Save();
            //MessageBox.Show("Токен сохранён!");
        }

        public void ResetToken()
        {
            Token = null;
            Client.DefaultRequestHeaders.Authorization = null;
            Settings.Default.ApiToken = null;
            Settings.Default.Save();
            //MessageBox.Show("Токен очищен!");
        }

        public string GetToken() { return Token; }

        public string GetUsername() { return JwtHelper.GetUsernameFromToken(Token); }

        protected void EnsureValidResponse(HttpResponseMessage response)
        {
            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                ResetToken();
                OnUnathorized?.Invoke(UNATHORIZED_MESSAGE);
                throw new UnauthorizedAccessException();
            }

            // Якщо помилка інша (наприклад 400 Bad Request або 500 Server Error)
            response.EnsureSuccessStatusCode();
        }

        public static readonly string UNATHORIZED_MESSAGE = "Час дії сесії вичерпано.\nБудь ласка, увійдіть знову!"; 
    }
}