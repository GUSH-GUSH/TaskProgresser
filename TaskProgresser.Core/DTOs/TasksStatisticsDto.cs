namespace TaskProgresser.Core.DTOs
{
    public class TaskStatisticsDto
    {
        public int TotalTasks { get; set; }
        public int ActiveTasks { get; set; }
        public int CompletedTasks { get; set; }
        public int NotStarted { get; set; }
        public int InProgress { get; set; }
        public int Overdue { get; set; }
        public int CompletedInTime { get; set; }
        public int CompletedLate { get; set; }
        public double AverageCompletionPercent { get; set; }
    }
}