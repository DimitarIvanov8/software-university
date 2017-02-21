using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            var mainNumbers = Console.ReadLine()
                .Split(' ')
                .ToList();

            var n = int.Parse(Console.ReadLine());
            var duplicate = "";

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine()
                    .Split(' ')
                    .ToList();              

                for (int j = mainNumbers.Count-1; j >= 0; j--) //main number list
                {
                    if (currentList.Contains(mainNumbers[j].ToString()))
                    {                       
                        duplicate = mainNumbers[j];

                        currentList.Remove($"{mainNumbers[j]}");
                        mainNumbers.Remove($"{mainNumbers[j]}");

                        while (mainNumbers.Contains(duplicate))
                        {
                            mainNumbers.Remove(duplicate);
                        }
                    }
                }

                for (int m = 0; m < currentList.Count; m++)
                {
                    mainNumbers.Add(currentList[m]);
                }
            }

            mainNumbers.Sort();
            var newIntList = new List<int>();

            for (int i = 0; i < mainNumbers.Count; i++)
            {
                newIntList.Add(int.Parse(mainNumbers[i]));
            }

            foreach (var item in newIntList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
