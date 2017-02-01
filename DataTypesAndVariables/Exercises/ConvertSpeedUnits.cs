using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int timeHours = int.Parse(Console.ReadLine());
            int timeMinutes = int.Parse(Console.ReadLine());
            int timeSeconds = int.Parse(Console.ReadLine());
            float mileToMeter = 1609f;
            float timeInSeconds = ((timeHours * 60f) * 60f) + (timeMinutes * 60f) + (float)timeSeconds;
            float timeInHours = timeHours + (timeMinutes / 60f) + ((timeSeconds / 60f) / 60f);

            float speedMetersPerSecond = distanceMeters / timeInSeconds;
            float speedKilometersPerHour = (distanceMeters / 1000) / timeInHours;
            float speedMilesPerHour = (distanceMeters / mileToMeter) / timeInHours; 

            Console.WriteLine(speedMetersPerSecond);
            Console.WriteLine(speedKilometersPerHour);
            Console.WriteLine(speedMilesPerHour);
        }
    }
}
