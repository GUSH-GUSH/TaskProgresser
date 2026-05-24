using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Core.Services
{
    public static class TaskAnalyticsService
    {
        public enum TaskState
        {
            NotStarted,
            InProgress,
            CompletedInTime,
            CompletedOvertime,
            Overduing
        }

        public static Dictionary<TaskState, string> TaskStateTitles = new Dictionary<TaskState, string>() {
            { TaskState.NotStarted, "Не розпочато" },
            { TaskState.InProgress, "В процесі" },
            { TaskState.CompletedInTime, "Виконано вчасно" },
            { TaskState.CompletedOvertime, "Виконано з затримкою" },
            { TaskState.Overduing, "Протерміновано" },
        };

        public static TaskState GetState(TaskItem task, DateTime timepoint)
        {
            if (!task.IsCompleted)
            {
                if (timepoint < task.StartDate)
                    return TaskState.NotStarted;
                if (timepoint <= task.EndDate)
                    return TaskState.InProgress;
                else return TaskState.Overduing;
            }
            else
            {
                if (task.CompletedAt <= task.EndDate)
                    return TaskState.CompletedInTime;
                else
                    return TaskState.CompletedOvertime;
            }
        }

        public static double CalculateEfficiency(TaskItem task)
        {
            return Math.Round(new DateRange(task.StartDate, task.EndDate).GetFractionOf(task.CompletedAt ?? DateTime.Now) * 100, task.Precision);
        }
    }
}
