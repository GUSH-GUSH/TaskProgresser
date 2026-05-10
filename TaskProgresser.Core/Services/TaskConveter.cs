using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Core.Services
{
    public static class TaskConverter
    {
        public static TaskItem FromJson(string json)
        {
            return JsonSerializer.Deserialize<TaskItem>(json);
        }

        public static string ToJson(TaskItem item) {
            return JsonSerializer.SerializeToDocument(item).ToString();
        }
    }
}
