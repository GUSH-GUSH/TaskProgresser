using Microsoft.EntityFrameworkCore;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


        #region --- TABLES ---

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

        #endregion --- TABLES ---


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Настройка таблицы Пользователей
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Username).IsRequired().HasMaxLength(50);
                entity.HasIndex(u => u.Username).IsUnique();
            });

            // Настройка таблицы Задач
            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Title).IsRequired().HasMaxLength(100);

                // Явно указываем связь: У одной задачи есть один UserId
                entity.HasOne<User>()
                      .WithMany()
                      .HasForeignKey(t => t.UserId)
                      .OnDelete(DeleteBehavior.Cascade); // Если удалить юзера, удалятся и его задачи
            });
        }
    }
}