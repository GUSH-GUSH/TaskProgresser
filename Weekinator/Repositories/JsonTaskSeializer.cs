using Newtonsoft.Json;
using System.Collections.Generic;
using Weekinator.Models;
using System.IO;

namespace Weekinator.Repositories
{
    internal static class JsonTaskSeializer
    {
        private static readonly string FilePath = "tasks.json";

        public static void SaveTasks(List<TaskItem> tasks)
        {
            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }

        public static List<TaskItem> LoadTasks()
        {
            if (!File.Exists(FilePath))
            {
                return new List<TaskItem>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonConvert.DeserializeObject<List<TaskItem>>(json) ?? new List<TaskItem>();
        }
    }
}
