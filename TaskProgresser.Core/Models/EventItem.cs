using System;
using System.Security.Cryptography;
using System.Text.Json.Serialization;

namespace TaskProgresser.Core.Models
{
    public class EventItem
    {
        public enum RepeatType { None, Daily, Weekly, Monthly, Yearly }

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Precision { get; set; } = 3;
        public bool ShowInTray { get; set; } = false;
        public Guid UserId { get; set; }
        public RepeatType Repeat { get; set; }
        
        public EventItem ToUTC()
        {
            return new EventItem
            {
                Id = this.Id,
                Title = this.Title,
                Description = this.Description,
                StartDate = this.StartDate.ToUniversalTime(),
                EndDate = this.EndDate.ToUniversalTime(),
                Precision = this.Precision,
                ShowInTray = this.ShowInTray,
                UserId = this.UserId,
                Repeat = this.Repeat
            };
        }

        public EventItem ToLocalTime()
        {
            return new EventItem
            {
                Id = this.Id,
                Title = this.Title,
                Description = this.Description,
                StartDate = this.StartDate.ToLocalTime(),
                EndDate = this.EndDate.ToLocalTime(),
                Precision = this.Precision,
                ShowInTray = this.ShowInTray,
                UserId = this.UserId,
                Repeat = this.Repeat
            };
        }
    }
}
