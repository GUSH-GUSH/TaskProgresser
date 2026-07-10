using System;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace TaskProgresser.Core.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int Precision { get; set; } = 3;
        public bool ShowInTray { get; set; } = false;

        public Guid UserId { get; set; }

        [JsonIgnore]
        public bool IsCompleted => CompletedAt.HasValue;

        public TaskItem ToUTC()
        {
            return new TaskItem
            {
                Id = this.Id,
                Title = this.Title,
                Description = this.Description,
                StartDate = this.StartDate.ToUniversalTime(),
                EndDate = this.EndDate.ToUniversalTime(),
                CompletedAt = this.CompletedAt?.ToUniversalTime(),
                Precision = this.Precision,
                ShowInTray = this.ShowInTray,
                UserId = this.UserId
            };
        }

        public TaskItem ToLocalTime()
        {
            return new TaskItem
            {
                Id = this.Id,
                Title = this.Title,
                Description = this.Description,
                StartDate = this.StartDate.ToLocalTime(),
                EndDate = this.EndDate.ToLocalTime(),
                CompletedAt = this.CompletedAt?.ToLocalTime(),
                Precision = this.Precision,
                ShowInTray = this.ShowInTray,
                UserId = this.UserId
            };
        }
    }
}
