using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.A_Miner_s_Task
{
    class MinersTask
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            Dictionary<string, int> mats = new Dictionary<string, int>();

            while (continueLoop)
            {
                string material = Console.ReadLine();

                int quantity = 0;
                if (material == "stop")
                {
                    continueLoop = false;
                    PrintSortedResults(mats);
                    break;
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine());
                }

                if (mats.ContainsKey(material))
                {
                    mats[material] += quantity;
                }
                else
                {
                    mats.Add(material, quantity);
                }
            }
        }

        private static void PrintSortedResults(Dictionary<string, int> mats)
        {
            foreach (var materials in mats)
            {
                Console.WriteLine($"{materials.Key} -> {materials.Value}");
            }
        }
    }
}
