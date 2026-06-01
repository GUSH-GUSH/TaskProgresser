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

        #if DEBUG
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrlDebug;
        #else
        protected static readonly string BaseUrl = Settings.Default.ApiBaseUrl;
        #endif

        public static string Token { get; private set; }
        
        public void SetToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) throw new ArgumentException("Token cannot be null or empty.", nameof(token));
            Token = token;
            Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        public void ResetToken()
        {
            Token = null;
            Client.DefaultRequestHeaders.Authorization = null;
        }
    }
}