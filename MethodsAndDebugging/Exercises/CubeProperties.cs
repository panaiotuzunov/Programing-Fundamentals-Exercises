using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal side = decimal.Parse(Console.ReadLine());
            string property = Console.ReadLine().ToLower();
            decimal result = 0;

            switch (property)
            {
                case "face":
                    result = GetCubeFace(side);
                    break;
                case "space":
                    result = GetCubeSpace(side);
                    break;
                case "volume":
                    result = GetCubeVolume(side);
                    break;
                case "area":
                    result = GetCubeArea(side);
                    break;
            }

            Console.WriteLine("{0:f2}", result);
        }

        private static decimal GetCubeArea(decimal side)
        {
            return (decimal)(6 * Math.Pow((double)side, 2));
        }

        private static decimal GetCubeVolume(decimal side)
        {
            return (decimal)Math.Pow((double)side, 3);
        }

        private static decimal GetCubeSpace(decimal side)
        {
            return (decimal)Math.Sqrt(3 * Math.Pow((double)side, 2));
        }

        private static decimal GetCubeFace(decimal side)
        {
            return (decimal)Math.Sqrt(2 * Math.Pow((double)side, 2));
        }
    }
}
