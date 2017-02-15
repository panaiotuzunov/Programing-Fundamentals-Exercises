using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPoints = int.Parse(Console.ReadLine());
            Point[] points = new Point[numberOfPoints];

            for (int p = 0; p < numberOfPoints; p++)
            {
                points[p] = GetPointCoordinates(points);
            }

            double minDistance = double.MaxValue;
            Point minFirst = new Point();
            Point minSecond = new Point();

            for (int firstPoint = 0; firstPoint < points.Length; firstPoint++)
            {
                for (int secondPoint = firstPoint + 1; secondPoint < points.Length; secondPoint++)
                {
                    double distance = CalculateDistanceBetweenTwoPoints(points[firstPoint], points[secondPoint]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        minFirst = points[firstPoint];
                        minSecond = points[secondPoint];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}\n({minFirst.X}, {minFirst.Y})\n({minSecond.X}, {minSecond.Y})");
        }

        private static Point GetPointCoordinates(Point[] points)
        {
            double[] pointArgs = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point point = new Point
            {
                X = pointArgs[0],
                Y = pointArgs[1]
            };

            return point;
        }

        private static double CalculateDistanceBetweenTwoPoints(Point firstPoint, Point secondPoint)
        {
            double a = firstPoint.X - secondPoint.X;
            double b = firstPoint.Y - secondPoint.Y;

            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
