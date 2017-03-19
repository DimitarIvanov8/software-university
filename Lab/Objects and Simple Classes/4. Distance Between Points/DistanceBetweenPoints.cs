using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            var firstPoint = ReadPoint();
            var secondPoint = ReadPoint();

            var result = Distance(firstPoint, secondPoint);
            Console.WriteLine($"{result:F3}");
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            var result = Math.Sqrt(squareX + squareY);
            return result;
        }

        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine()
                .Split(' ');

            return new Point
            {
                X = double.Parse(pointParts[0]),
                Y = double.Parse(pointParts[1])
            };
        }
    }
}
