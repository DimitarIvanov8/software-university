using System;

namespace _4.Refactor_Volume_of_Pyramid
{
    class RefactorVolumeOfPyramid
    {
        static void Main()
        {
            double length = 0;
            double width = 0; 
            double height = 0;
            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = 0;
            volume = (length * width * height) / 3d;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
