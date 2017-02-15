using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstPointArgs = Console.ReadLine().Split();
            string[] secondPointArgs = Console.ReadLine().Split();

            var firstPoint = new Point
            {
                X = double.Parse(firstPointArgs[0]),
                Y = double.Parse(firstPointArgs[1])
            };

            var secondPoint = new Point
            {
                X = double.Parse(secondPointArgs[0]),
                Y = double.Parse(secondPointArgs[1])
            };

            var distance = CalculateDistanceBetweenTwoPoints(firstPoint, secondPoint);
            Console.WriteLine($"{distance:f3}");
        }

        private static object CalculateDistanceBetweenTwoPoints(Point firstPoint, Point secondPoint)
        {
            double a = firstPoint.X - secondPoint.X;
            double b = firstPoint.Y - secondPoint.Y;

            return Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));
        }
    }
}
