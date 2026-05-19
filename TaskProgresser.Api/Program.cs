using Microsoft.EntityFrameworkCore;
using TaskProgresser.Api.Services;
using TaskProgresser.Api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DataBase Context

var connectionString = builder.Configuration.GetConnectionString("AivenConnection");
var serverVersion = new MySqlServerVersion(new Version(8, 4, 8));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, serverVersion)
           .LogTo(Console.WriteLine, LogLevel.Information) // Отличная штука для отладки: выводит все SQL-запросы в консоль
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<JsonTaskService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
