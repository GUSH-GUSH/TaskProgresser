using System.Net.Http;
using System.Net.Http.Headers;
using System;
using TaskProgresser.WinForms.Properties;

namespace TaskProgresser.Client.ApiClients
{
    public abstract class BaseApiClient
    {
        protected static readonly HttpClient Client = new HttpClient();
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrl;

        public static void SetToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Token cannot be null or empty.", nameof(token));
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static void ResetToken() => Client.DefaultRequestHeaders.Authorization = null;
    }
}