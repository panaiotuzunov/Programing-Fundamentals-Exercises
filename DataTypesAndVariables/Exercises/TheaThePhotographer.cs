using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte inputCenturies = byte.Parse(Console.ReadLine());
            short years = (short)(inputCenturies * 100);
            int days = (int)(365.2422 * years);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                inputCenturies, years, days, hours, minutes);
        }
    }
}
