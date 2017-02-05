using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_triangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var triangleArea = CalculateArea(width, height);

            Console.WriteLine(triangleArea);
        }

        private static double CalculateArea(double width, double height)
        {
            var area = (width * height) / 2;
            return area;
        }
    }
}