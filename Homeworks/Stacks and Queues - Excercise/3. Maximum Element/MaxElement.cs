using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Maximum_Element
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            var stackMaxNumbers = new Stack<long>();

            var maxNumInStack = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                var currentNumbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
                var currentNum = 0l;

                if (currentNumbers.Length == 1)
                {
                    currentNum = currentNumbers[0];
                    if (currentNum == 2)
                    {
                        if (stack.Pop() == maxNumInStack)
                        {
                            stackMaxNumbers.Pop();

                            if (stackMaxNumbers.Count() != 0)
                            {
                                maxNumInStack = stackMaxNumbers.Peek();
                            }
                            else
                            {
                                maxNumInStack = long.MinValue;
                            }
                        }                       
                    }
                    else if (currentNum == 3)
                    {
                        Console.WriteLine(maxNumInStack);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    currentNum = currentNumbers[1];
                    if (currentNum >= 1 && currentNumbers[0] == 1)
                    {
                        stack.Push(currentNum);

                        if (currentNum > maxNumInStack) //max check
                        {
                            maxNumInStack = currentNum;
                            stackMaxNumbers.Push(maxNumInStack);
                        }
                    }
                }
            }
        }
    }
}
