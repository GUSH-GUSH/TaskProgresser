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
    options.UseMySql(connectionString, serverVersion, mySqlOptions => mySqlOptions.EnableRetryOnFailure()) // <--- Добавили защиту от обрывов связи)
           .LogTo(Console.WriteLine, LogLevel.Information) // Отличная штука для отладки: выводит все SQL-запросы в консоль
);

// JWT Authentication setup

var secretKey = builder.Configuration["JwtSettings:Secret"];
var key = Encoding.ASCII.GetBytes(secretKey!);

builder.Services.AddAuthentication(options =>
{
    // Говорим ASP.NET по умолчанию использовать JWT Bearer
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    //options.RequireHttpsMetadata = false; // Для тестов на локалке ставим false
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

builder.Services.AddScoped<JsonTaskService>();
builder.Services.AddScoped<StatisticsService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// ... 

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

app.UseAuthentication(); // Добавить эту строку!
app.UseAuthorization();

app.MapControllers();

app.Run();
