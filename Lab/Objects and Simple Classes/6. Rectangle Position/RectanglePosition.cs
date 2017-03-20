using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            var firstRect = ReadRectangle();
            var secondRect = ReadRectangle();

            var result = firstRect.IsInside(secondRect);

            var printResult = result 
                ? "Inside" 
                : "Not inside";

            Console.WriteLine(printResult);
        }

        public static Rectangle ReadRectangle()
        {
            var rectangleParts = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            return new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
        }
    }
}
