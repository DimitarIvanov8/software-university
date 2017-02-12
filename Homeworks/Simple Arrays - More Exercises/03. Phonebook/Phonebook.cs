using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ');

            var names = Console.ReadLine()
                .Split(' ');

            bool done = false;

            do
            {
                var currentName = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (currentName == names[i])
                    {
                        Console.WriteLine($"{currentName} -> {numbers[i]}");
                    }
                }

                if (currentName == "done")
                {
                    done = true;
                }
            } while (done == false);
        }
    }
}
