using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double courses = Math.Ceiling(n / (4 + 8d + 12));
            Console.WriteLine(courses);
        }
    }
}
