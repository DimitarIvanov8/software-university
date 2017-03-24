using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfBoxes = new List<Box>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] tokens = line.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Box currentBox = new Box();

                currentBox.UpperLeft = new Point();
                currentBox.UpperLeft = currentBox.UpperLeft.ReadPoint(tokens[0]);

                currentBox.UpperRight = new Point();
                currentBox.UpperRight = currentBox.UpperRight.ReadPoint(tokens[1]);

                currentBox.BottomLeft = new Point();
                currentBox.BottomLeft = currentBox.BottomLeft.ReadPoint(tokens[2]);

                currentBox.BottomRigh = new Point();
                currentBox.BottomRigh = currentBox.BottomRigh.ReadPoint(tokens[3]);

                listOfBoxes.Add(currentBox);

                line = Console.ReadLine();
            }

            foreach (var box in listOfBoxes)
            {
                double width = CalculateDistance(box.UpperLeft, box.UpperRight);
                double height = CalculateDistance(box.UpperLeft, box.BottomLeft);

                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {box.CalculateArea(width, height)}");
            }

        }
        public static double CalculateDistance(Point first, Point second)
        {
            double squareX = Math.Pow(first.X - second.X, 2);
            double squareY = Math.Pow(first.Y - second.Y, 2);

            double result = Math.Sqrt(squareX + squareY);
            return result;
        }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point ReadPoint(string currentPointsAsString)
        {

            double[] PointParts = currentPointsAsString.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            return new Point()
            {
                X = PointParts[0],
                Y = PointParts[1]
            };
        }
    }
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRigh { get; set; }

        public double CalculatePerimeter(double width, double height)
        {
            return 2 * width + 2 * height;
        }

        public double CalculateArea(double width, double heigh)
        {
            return width * heigh;
        }
    }
}
