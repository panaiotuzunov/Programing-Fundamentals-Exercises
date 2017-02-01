using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int element = int.Parse(Console.ReadLine());
            bool isInRange = (element - 1) >= 0 && (element - 1) <= (daysOfWeek.Length - 1);

            if (isInRange)
            {
                Console.WriteLine(daysOfWeek[element - 1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
