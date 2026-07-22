using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;


namespace TaskProgresser.Core.Helpers
{

    public static class JwtHelper
    {
        public static string GetUsernameFromToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) return null;

            var handler = new JwtSecurityTokenHandler();

            // Проверяем, действительно ли это JWT токен, чтобы избежать ошибок парсинга
            if (!handler.CanReadToken(token)) return null;

            // Декодируем токен
            var jwtToken = handler.ReadJwtToken(token);

            // Ищем Claim (утверждение), в котором хранится логин.
            var nameClaim = jwtToken.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)
                         ?? jwtToken.Claims.FirstOrDefault(c => c.Type == "unique_name");

            return nameClaim?.Value;
        }
    }
}