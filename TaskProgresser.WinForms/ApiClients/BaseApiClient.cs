using System.Net.Http;
using System.Net.Http.Headers;
using System;
using TaskProgresser.WinForms.Properties;
using System.Security.Principal;

namespace TaskProgresser.WinForms.ApiClients
{
    public abstract class BaseApiClient
    {
        protected static readonly HttpClient Client = new HttpClient();
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrl;
        
        public static string Token { get; private set; }
        
        public static void SetToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Token cannot be null or empty.", nameof(token));
            Token = token;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public static void ResetToken()
        {
            Token = null;
            Client.DefaultRequestHeaders.Authorization = null;
        }
    }
}