using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            var minimumDistace = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];
                    var distance = Distance(firstPoint, secondPoint);

                    if (distance < minimumDistace)
                    {
                        minimumDistace = distance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minimumDistace:F3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
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
