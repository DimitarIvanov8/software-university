using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class EqualSumAFterExtraction
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var finalList = new List<int>();

            for (int i = 0; i < secondList.Count; i++) //second list
            {
                for (int j = 0; j < firstList.Count; j++) //first list
                {
                    if (secondList[i] == firstList[j]) //do nothing
                    {
                        secondList.RemoveAt(i);
                        j = 0;
                        i = 0;
                        continue;
                    }
                }
            }

            if (Math.Abs(firstList.Sum()) == Math.Abs(secondList.Sum()))
            {
                Console.WriteLine("Yes. Sum: " + Math.Abs(secondList.Sum()));
            }
            else
            {
                Console.WriteLine("No. Diff: " + Math.Abs(secondList.Sum() - firstList.Sum()));
            }
        }
    }
}
