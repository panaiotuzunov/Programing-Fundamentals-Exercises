using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long ammountOfPictures = int.Parse(Console.ReadLine());
            long timeForFiltering = int.Parse(Console.ReadLine());
            long percentageOfGoodPictures = int.Parse(Console.ReadLine());
            long timeForUploading = int.Parse(Console.ReadLine());

            long filteredPictures = (long)Math.Ceiling((double)ammountOfPictures * (percentageOfGoodPictures / 100d));
            long totalTimeInSeconds = (ammountOfPictures * timeForFiltering) + (filteredPictures * timeForUploading);

            long days = totalTimeInSeconds / 86400;
            long hours = (totalTimeInSeconds % 86400) / 3600;
            long minutes = (totalTimeInSeconds % 3600) / 60;
            long seconds = (totalTimeInSeconds % 3600) % 60;

            Console.WriteLine(
                "{0}:{1}:{2}:{3}", days, hours.ToString().PadLeft(2, '0')
                , minutes.ToString().PadLeft(2, '0')
                , seconds.ToString().PadLeft(2, '0')
                );
        }
    }
}
