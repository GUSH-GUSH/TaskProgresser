using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using TaskProgresser.Core.Models;

namespace TaskProgresser.Core.Helpers
{
    public static class JsonTaskConverter
    {
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true , PropertyNameCaseInsensitive = true };

        public static TaskItem FromJson(string json)
        {
            return JsonSerializer.Deserialize<TaskItem>(json, options);
        }
        
        public static List<TaskItem> FromJsonArray(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<List<TaskItem>>(json, options);
            }
            catch { return new List<TaskItem>(); }
        }

        public static string ToJson(TaskItem item) {
            return JsonSerializer.Serialize(item, options);
        }
        
        public static string ToJson(IEnumerable<TaskItem> item)
        {
            return JsonSerializer.Serialize(item, options);
        }
    }
}
