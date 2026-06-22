using BCrypt.Net;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TaskProgresser.Api.Data;
using TaskProgresser.Core.DTOs;
using TaskProgresser.Core.Models;
using TaskProgresser.Core.Validators;

namespace TaskProgresser.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IConfiguration _configuration;

        public AuthController(AppDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthRequest request)
        {
            //Валідація логіну та паролю
            if (!AuthValidator.ValidateLogin(request.Username))
                return BadRequest(AuthValidator.LOGIN_ERROR_MESSAGE);

            if (!AuthValidator.ValidatePassword(request.Password))
                return BadRequest(AuthValidator.PASSWORD_ERROR_MESSAGE);

            //Певірка, чи існує вже користувач з таким логіном
            if (await _context.Users.AnyAsync(u => u.Username == request.Username))
                return BadRequest($"Ім'я користувача {request.Username} зайнято");

            //Зберігаємо користувача з захешованим паролем
            var user = new User
            {
                Username = request.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(request.Password)
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return Ok($"Користувача {user.Username} успішно зареєстровано");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthRequest request)
        {
            //Пошук відповідного користувача за логіном у базі даних
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == request.Username);

            //Якщо логін не знайдено, або хеші паролів не співпадають - повертаємо помилку авторизації
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
                return Unauthorized("Невірний логін або пароль");

            //Інакше генеруємо JWT токен і повертаємо його клієнту разом з ім'ям користувача
            var token = GenerateJwtToken(user);
            return Ok(new AuthResponse { Token = token, Username = user.Username });
        }

        private string GenerateJwtToken(User user)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["JwtSettings:Secret"]!);
            var tokenHandler = new JwtSecurityTokenHandler();

            var descriptor = new SecurityTokenDescriptor
            {
                // Додаємо ID користувача всередину токена для ідентифікації
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Username)
                }),
                Expires = DateTime.UtcNow.AddDays(7), // Термін дії токену - 7 днів
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                                            SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(descriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}