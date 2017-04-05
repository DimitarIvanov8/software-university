using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Capitalize_Words
{
    class CapitalizeWords
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            StringBuilder words = new StringBuilder();

            while (line != "end")
            {
                string[] inputParams = line.Split(new[] { '.', '-', ',', '!', '?', ';', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in inputParams)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 0)
                        {
                            words.Append(word[i].ToString().ToUpper());
                        }
                        else
                        {
                            words.Append(word[i].ToString().ToLower());
                        }
                        if (i == word.Length - 1)
                        {
                            words.Append(", ");         //adding ", " after each word
                        }
                    }
                }
                var builderLength = words.Length - 2;
                words = words.Remove(builderLength, 1); //removing ", " from the end of each sentence
                words.Append("\n");                     //adding new Line after each sentece

                line = Console.ReadLine();
            }
            Console.WriteLine(words);
        }
    }
}
