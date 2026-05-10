using Microsoft.EntityFrameworkCore;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Эта строчка говорит: "Создай таблицу Tasks на основе класса TaskItem"
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Здесь можно настроить то, что нельзя сделать в Core проекте
            // Например, указать, что Title обязателен (NOT NULL)
            modelBuilder.Entity<TaskItem>().Property(t => t.Title).IsRequired();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}