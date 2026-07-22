using System;
using System.Collections.Generic;
using System.Linq;
using TaskProgresser.Core.Models;

namespace TaskProgresser.WinForms.Services
{
    public class TaskFilterController
    {
      /*  public IEnumerable<TaskItem> Process(
            IEnumerable<TaskItem> source,
            string searchQuery,
            int sortIndex)
        {
            IEnumerable<TaskItem> result = source;

            // 1. Фильтрация по поиску
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                string query = searchQuery.Trim().ToLower();
                result = result.Where(t => t.Title.ToLower().Contains(query));
            }

            // 2. Сортировка
            switch (sortIndex)
            {
                case 1: // Новые
                    result = result.OrderByDescending(t => t.CreatedAt);
                    break;
                case 2: // Старые
                    result = result.OrderBy(t => t.CreatedAt);
                    break;
                case 3: // Дедлайн близко
                    result = result.OrderBy(t => t.DueDate);
                    break;
                case 4: // Длительность
                    result = result.OrderByDescending(t => t.DurationInDays);
                    break;
            }

            return result;
        }*/
    }
}