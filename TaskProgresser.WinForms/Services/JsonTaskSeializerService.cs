using System.IO;
using System.Collections.Generic;

using TaskProgresser.Core.Models;
using System.Linq;
using TaskProgresser.Core.Helpers;

namespace TaskProgresser.WinForms.Repositories
{
    internal static class JsonTaskSeializerService
    {
        private static readonly string FilePath = "tasks.json";

        public static void SaveTasks(List<TaskItem> tasks)
        {
            string json = JsonTaskConverter.ToJson(tasks);
            File.WriteAllText(FilePath, json);
        }

        public static List<TaskItem> LoadTasks()
        {
            if (!File.Exists(FilePath))
            {
                return new List<TaskItem>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonTaskConverter.FromJsonArray(json).ToList();
        }
    }
}
