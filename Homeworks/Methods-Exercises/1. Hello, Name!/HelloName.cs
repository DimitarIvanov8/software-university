using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello__Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var fullGreetings = Greetings(name);
            Console.WriteLine(fullGreetings);
        }

        static string Greetings(string name)
        {
            var greetingsName = $"Hello, {name}!";
            return greetingsName;
        }
    }
}
