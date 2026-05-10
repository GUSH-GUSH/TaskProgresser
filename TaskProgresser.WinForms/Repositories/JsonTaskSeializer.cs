using System.IO;
using System.Collections.Generic;

using TaskProgresser.Core.Models;
using TaskProgresser.Core.Services;
using System.Linq;

namespace TaskProgresser.WinForms.Repositories
{
    internal static class JsonTaskSeializer
    {
        private static readonly string FilePath = "tasks.json";

        public static void SaveTasks(List<TaskItem> tasks)
        {
            string json = TaskConverter.ToJson(tasks);
            File.WriteAllText(FilePath, json);
        }

        public static List<TaskItem> LoadTasks()
        {
            if (!File.Exists(FilePath))
            {
                return new List<TaskItem>();
            }

            string json = File.ReadAllText(FilePath);
            return TaskConverter.FromJsonArray(json).ToList();
        }
    }
}
