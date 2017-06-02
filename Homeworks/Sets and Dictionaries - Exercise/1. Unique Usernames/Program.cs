using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a simple program that reads from the console a sequence of usernames
            // and keeps a collection with only the unique ones. Print the collection on the console.

            int numberOfCommands = int.Parse(Console.ReadLine());
            HashSet<string> mySet = new HashSet<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string input = Console.ReadLine();
                mySet.Add(input);
            }

            foreach (var element in mySet)
            {
                Console.WriteLine(element);
            }
        }
    }
}
