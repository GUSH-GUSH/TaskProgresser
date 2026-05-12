using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using TaskProgresser.Core.Models;


//+Пофиксить сериализацию в текст (как её нормально сдеать)
//+Разобраться с DateTimeToolKit - или вынести его в Core, или по-адекватному установить через NuGet во все проекты.
//+Вспомнить, почему я не делал это через NuGet-пакет
//-Перевести этот пакет, при надобности, на .Net Standart 2.0

//*** После успешного перехода WinForms проекта на модели данных из Core: ***

//Разбираться с Api-проектом
//AppDbContext
//Подключение к MySql (локальному, а потом и удалённому)
//Миграции/перенос моеделей из кода в БД (CodeFirst)
//Регистрация/авторизация
//Полноценное Web-Api




namespace TaskProgresser.Core.Services
{
    public static class TaskConverter
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions() { WriteIndented = true };
        
        public static TaskItem FromJson(string json)
        {
            return JsonSerializer.Deserialize<TaskItem>(json);
        }
        public static IEnumerable<TaskItem> FromJsonArray(string json)
        {
            try
            {
                return JsonSerializer.Deserialize<IEnumerable<TaskItem>>(json);
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
