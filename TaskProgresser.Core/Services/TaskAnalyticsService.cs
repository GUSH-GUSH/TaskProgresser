using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Core.Services
{
    public static class TaskAnalyticsService
    {
        public static double CalculateEfficiency(TaskItem task)
        {
            return Math.Round(new DateRange(task.StartDate, task.EndDate).GetFractionOf(task.CompletedAt ?? DateTime.Now) * 100, task.Precision);
        }
    }
}
