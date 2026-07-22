using TaskProgresser.WinForms.Properties;

namespace TaskProgresser.WinForms.Services
{
    public static class TokenService
    {
        public static void SaveTokenToSettings(string token)
        {

            Settings.Default.ApiToken = token;
            Settings.Default.Save();
            //MessageBox.Show("Токен сохранён!");
        }

        public static void ResetTokenInSettings()
        {
            Settings.Default.ApiToken = null;
            Settings.Default.Save();
        }
        
        public static string GetTokenFromSettings()
        {
            return Settings.Default.ApiToken;
        }
    }
}
