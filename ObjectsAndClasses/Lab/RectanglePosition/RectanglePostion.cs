using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangleParameters();
            Rectangle secondRectangle = ReadRectangleParameters();

            Console.WriteLine(IsInside(firstRectangle, secondRectangle));
        }

        private static string IsInside(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            bool isInside =
                firstRectangle.Left >= secondRectangle.Left &&
                firstRectangle.Right <= secondRectangle.Right &&
                firstRectangle.Top <= secondRectangle.Top &&
                firstRectangle.Bottom <= secondRectangle.Bottom;

            return isInside ? "Inside" : "Not Inside";
        }

        private static Rectangle ReadRectangleParameters()
        {
            var rectagleArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rectangle = new Rectangle
            {
                Left = rectagleArgs[0],
                Top = rectagleArgs[1],
                Width = rectagleArgs[2],
                Height = rectagleArgs[3],
            };

            return rectangle;
        }
    }
}
