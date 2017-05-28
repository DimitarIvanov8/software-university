using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Basic_Stack_Operations
{
    class StackOperations
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            var numsToPush = input[0];
            var numsToPop = input[1];
            var isNumPresent = input[2];

            var currentNums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            if (currentNums.Length != numsToPush)
            {
                return;
            }

            for (int i = 0; i < currentNums.Length; i++)
            {
                stack.Push(currentNums[i]);
            }

            for (int i = 0; i < numsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(isNumPresent))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
