using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Array_Symmetry
{
    class ArraySymetry
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ');

            bool isSymetric = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[text.Length - i - 1])
                {
                    isSymetric = true;
                }
                else
                {
                    isSymetric = false;
                    Console.WriteLine("No");
                    return;
                }
            }

            if (isSymetric == true)
            {
                Console.WriteLine("Yes");
            }
        }
    }
}
