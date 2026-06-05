using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TaskProgresser.Api.Data;
using TaskProgresser.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// For working on Render.com

#if !DEBUG

var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
builder.WebHost.UseUrls($"http://*:{port}");

#endif

// Add DataBase Context

var connectionString = builder.Configuration.GetConnectionString("AivenConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 4, 8));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, serverVersion, mySqlOptions => mySqlOptions.EnableRetryOnFailure())
           .LogTo(Console.WriteLine, LogLevel.Information)
);

// JWT Authentication setup

var secretKey = builder.Configuration["JwtSettings:Secret"];
var key = Encoding.ASCII.GetBytes(secretKey!);

builder.Services.AddAuthentication(options =>
{
    // Вказуємо ASP.NET за замовчуванням використовувати JWT Bearer
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false, // В реальных проектах тут проверяют домен сервера
        ValidateAudience = false, // А тут домен клиента
        ClockSkew = TimeSpan.Zero // Точное время истечения токена
    };
});

// Add services to the container.

builder.Services.AddScoped<StatisticsService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// Заменяем стандартный AddSwaggerGen на этот:
builder.Services.AddSwaggerGen(c =>
{
    // 1. Добавляем кнопку "Authorize" и описываем, как она работает
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Введите JWT токен в формате: Bearer {ваш_токен}\n\nПример: Bearer eyJhbGciOiJIUzI1Ni...",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    // 2. Указываем, что этот токен нужно прикреплять ко всем защищенным эндпоинтам
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthentication(); // для защищенных эндпоинтов, чтобы ASP.NET знал, что нужно проверять токен
app.UseAuthorization();

app.MapControllers();

app.Run();
