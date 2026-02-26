using DateTimeToolKit.Models.DateRange;
using Newtonsoft.Json;
using System;

namespace TaskProgresser.Models
{
    public class TaskItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? CompletedAt { get; set; }
        public int Precision { get; set; } = 3;
        public bool ShowInTray { get; set; } = false;

        [JsonIgnore]
        public bool IsCompleted => CompletedAt.HasValue;
        [JsonIgnore]
        public double EfficiencyPercentage => Math.Round(new DateRange(StartDate, EndDate).GetFractionOf(CompletedAt ?? DateTime.Now) * 100, Precision);
    }
}
