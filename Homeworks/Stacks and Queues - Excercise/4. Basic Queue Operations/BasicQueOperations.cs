using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Basic_Queue_Operations
{
    class BasicQueOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            var numsToEnqueue = input[0];
            var numsToDequeue = input[1];
            var isNumPresent = input[2];

            var currentNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (currentNums.Length != numsToEnqueue)
            {
                return;
            }

            for (int i = 0; i < currentNums.Length; i++)
            {
                queue.Enqueue(currentNums[i]);
            }

            for (int i = 0; i < numsToDequeue; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(isNumPresent))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
