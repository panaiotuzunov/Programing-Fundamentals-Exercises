using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            double result = 0;

            switch (figureType)
            {
                case "triangle":
                    result = CalculateTriangleArea();
                    break;

                case "square":
                    result = CalculateSquareArea();
                    break;

                case "rectangle":
                    result = CalculateRectangleArea();
                    break;

                case "circle":
                    result = CalculateCircleArea();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.WriteLine("{0:f2}", result);
        }

        private static double CalculateCircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            return Math.PI * radius * radius;
        }

        private static double CalculateRectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return width * height;
        }

        private static double CalculateSquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            return side * side;
        }

        private static double CalculateTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            return side * height / 2d;
        }
    }
}
