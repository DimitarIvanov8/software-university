using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Elements_at_Odd_Positions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToList();

            var newListy = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                if (i % 2 != 0)
                {
                    newListy.Add(text[i]);
                }
            }

            foreach (var item in newListy)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        } 
    }
}
