using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class IncrementVar
    {
        static void Main(string[] args)
        {
            int numOfTimes = int.Parse(Console.ReadLine());
            int counter = 0;
            byte overFlowCount = 0;

            for (int i = 0; i < numOfTimes; i++)
            {
                if (counter == byte.MaxValue)
                {
                    counter = 0;
                    overFlowCount++;
                    continue;
                }
                counter++;
            }

            if (overFlowCount == 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine(counter);
                Console.WriteLine("Overflowed {0} times", overFlowCount);
            }
        }
    }
}
