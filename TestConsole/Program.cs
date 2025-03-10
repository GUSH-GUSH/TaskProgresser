using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyUtils;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateRange myFirstDateRange = new DateRange(new DateTime(2025,02,03), new DateTime(2025,05,23));

            Console.WriteLine($"Range: {myFirstDateRange}");
            Console.WriteLine($"Fraction: {myFirstDateRange.GetFractionOf(DateTime.Now)}");
            Console.WriteLine($"Total precent: {Math.Round(myFirstDateRange.GetFractionOf(DateTime.Now)*100, 3)}%");

            var tspn = new TimeSpan(500,60, 15, 5);

            Console.WriteLine();
            Console.WriteLine(tspn);
            Console.WriteLine(DateTime.Now + tspn);

        }
    }
}
