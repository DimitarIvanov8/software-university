using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Periodic_Table
{
    class PeriodicTable
    {
        static void Main(string[] args)
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            HashSet<string> set = new HashSet<string>();
            for (int i = 0; i < numberOfElements; i++)
            {
                string[] elements = Console.ReadLine()
                    .Trim()
                    .Split()
                    .ToArray();
                for (int j = 0; j < elements.Length; j++)
                {
                    set.Add(elements[j]);
                }
            }

            set.OrderBy(s => s);

            foreach (var element in set)
            {
                Console.Write("{0} ", element);
            }
        }
    }
}
