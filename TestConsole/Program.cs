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

            DateRange myFirstDateRange = new DateRange(new DateTime(2025, 02, 03), new DateTime(2025, 05, 23));

            Console.WriteLine($"Range: {myFirstDateRange}");
            Console.WriteLine($"Fraction: {myFirstDateRange.GetFractionOf(DateTime.Now)}");
            Console.WriteLine($"Total precent: {Math.Round(myFirstDateRange.GetFractionOf(DateTime.Now) * 100, 3)}%");
            Console.WriteLine($"Semester length: {myFirstDateRange.Length.Days} days");
            Console.WriteLine();

            DateRange mySecondDateRange = new DateRange(new DateTime(2025, 02, 03), new TimeSpan(109, 0, 0, 0));
            Console.WriteLine($"Range: {mySecondDateRange}");
            Console.WriteLine($"Fraction: {mySecondDateRange.GetFractionOf(DateTime.Now)}");
            Console.WriteLine($"Total precent: {Math.Round(mySecondDateRange.GetFractionOf(DateTime.Now) * 100, 3)}%");
            Console.WriteLine($"Semester length: {mySecondDateRange.Length.Days} days");
            
            Console.WriteLine();

            
            int dayOfSemester = 15;

            DateTime dateTime = myFirstDateRange.Start + new TimeSpan(dayOfSemester - 1,0,0,0);
            
            int numOfWeek = (int)((dateTime - myFirstDateRange.Start).TotalDays / 7) + 1;

            Console.WriteLine($"Range: {mySecondDateRange}");
            Console.WriteLine($"Day of semester: {dayOfSemester}");
            Console.WriteLine($"Date: {dateTime}");
            Console.WriteLine($"Num of week: {numOfWeek}");
            Console.WriteLine($"Day of week: {dateTime.DayOfWeek}");
            Console.WriteLine($"Total precent: {Math.Round(myFirstDateRange.GetFractionOf(dateTime) * 100, 3)}%");
            Console.WriteLine($"Week mark: " + ((numOfWeek % 2 == 0) ? "Znamenyk" : "Chiselnyk"));

            Console.WriteLine(Math.Ceiling(myFirstDateRange.Length.TotalDays / 7));



            


            var tspn = new TimeSpan(500, 60, 15, 5);
        }
    }
}
