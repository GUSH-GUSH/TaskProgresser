using System;
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
        //[JsonIgnore]
        //public double EfficiencyPercentage => Math.Round(new DateRange(StartDate, EndDate).GetFractionOf(CompletedAt ?? DateTime.Now) * 100, Precision);
    }
}
