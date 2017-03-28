using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Reverse().ToList();
            Console.WriteLine(String.Join("",text));
        }
    }
}
