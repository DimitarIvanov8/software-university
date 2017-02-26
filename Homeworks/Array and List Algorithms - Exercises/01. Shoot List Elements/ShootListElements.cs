using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shoot_List_Elements
{
    class ShootListElements
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            var currentInput = new List<string>();
            var lastNumber = 0;

            do
            {
                currentInput.Add(Console.ReadLine());

                if (currentInput.Last() != "bang" && currentInput.Last() != "stop")
                {
                    //add to numbers
                    numbers.Insert(0, int.Parse(currentInput.Last()));
                }
                else if (currentInput.Last() == "bang")
                {
                    //bang numbers
                    var averageNum = 0d;

                    if (numbers.Count >= 1)
                    {
                        averageNum = numbers.Average();
                    }

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("nobody left to shoot! last one was " + lastNumber);
                        return;
                    }

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] < averageNum)
                        {
                            Console.WriteLine("shot " + numbers[i]);                         
                            numbers.RemoveAt(i);

                            for (int j = 0; j < numbers.Count; j++)
                            {
                                numbers[j] -= 1;
                            }
                            break;
                        }

                        if (numbers.Count == 1)
                        {
                            Console.WriteLine("shot " + numbers[i]);
                            lastNumber = numbers[0];
                            numbers.RemoveAt(i);
                        }
                    }
                }

                else if (currentInput.Last() == "stop")
                {
                    if (numbers.Count >= 1)
                    {
                        Console.Write("survivors: " + String.Join(" ", numbers));
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("you shot them all. last one was " + lastNumber);
                    }
                }

            } while (currentInput.Last() != "stop");
        }
    }
}
