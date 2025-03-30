using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUtils;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateRange dateRange = new DateRange(new DateTime(2025, 02, 03), new DateTime(2025, 05, 23));

            Console.WriteLine();

            DateTime point = DateTime.Now;

            Console.WriteLine($"Range: {dateRange}");
            Console.WriteLine($"Date: {point}");
            Console.WriteLine($"Day of semester: {dateRange.GetDayOf(point)}/{dateRange.TotalDays}");
            Console.WriteLine($"Num of week: {dateRange.GetWeekOf(point)}/{dateRange.TotalWeeks}");
            Console.WriteLine($"Day of week: {point.DayOfWeek}");
            Console.WriteLine($"Total precent: {Math.Round(dateRange.GetFractionOf(point) * 100, 3)}%");
            Console.WriteLine($"Week mark: " + ((dateRange.GetWeekOf(point) % 2 == 0) ? "Znamenyk" : "Chiselnyk"));

            Console.ReadLine();


            


            var tspn = new TimeSpan(500, 60, 15, 5);
        }
    }
}
