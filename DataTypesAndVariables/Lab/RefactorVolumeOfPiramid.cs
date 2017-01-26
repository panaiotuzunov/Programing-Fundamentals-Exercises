using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RefactorVolumeOfPiramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double pyramidVolume = (length/3) * width * height;
            Console.WriteLine("Pyramid Volume: {0:F2}", pyramidVolume);
        }
    }
}
