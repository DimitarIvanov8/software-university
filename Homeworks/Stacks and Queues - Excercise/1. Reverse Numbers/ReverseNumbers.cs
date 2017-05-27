using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Numbers
{
    class ReverseNumbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                stack.Push(numbers[i]);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
    }
}
