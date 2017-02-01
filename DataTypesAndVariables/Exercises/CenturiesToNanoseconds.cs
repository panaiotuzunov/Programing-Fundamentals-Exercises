using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CenturiesToNanoseconds
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
            decimal seconds = minutes * 60m;
            decimal milliSeconds = seconds * 1000m;
            decimal microSeconds = milliSeconds * 1000m;
            decimal nanoSeconds = microSeconds * 1000m;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                inputCenturies, years, days, hours, minutes, seconds, milliSeconds, microSeconds, nanoSeconds);
        }
    }
}
