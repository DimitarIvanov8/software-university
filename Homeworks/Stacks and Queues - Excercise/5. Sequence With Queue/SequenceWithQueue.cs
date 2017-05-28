using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Sequence_With_Queue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(n);

            for (int i = 0; i < 50; i++)
            {
                var currentElement = queue.Dequeue();
                Console.Write(currentElement + " ");
                queue.Enqueue(currentElement + 1);
                queue.Enqueue(2 * currentElement + 1);
                queue.Enqueue(currentElement + 2);
            }
            Console.WriteLine();
        }
    }
}
