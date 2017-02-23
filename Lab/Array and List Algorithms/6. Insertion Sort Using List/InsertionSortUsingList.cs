using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Insertion_Sort_Using_List
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                bool inserted = false;
                int currentElement = input[i];

                for (int j = 0; j < result.Count; j++)
                {
                    int currenResultElement = result[j];

                    if (currentElement <= currenResultElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, j), currentElement);
                        break;
                    }
                }
                if (!inserted)
                {
                    result.Add(currentElement);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
