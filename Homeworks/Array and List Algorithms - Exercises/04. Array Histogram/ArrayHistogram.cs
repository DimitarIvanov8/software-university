using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Array_Histogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToList();

            var words = new List<string>();
            var occurrence = new List<int>();
            var currentWord = "";

            for (int i = 0; i < text.Count; i++)
            {
                currentWord = text[i];

                if (!words.Contains(currentWord))
                {
                    words.Add(currentWord);
                    occurrence.Add(1);
                }
                else if (words.Contains(currentWord))
                {
                    var currentWordIndex = words.IndexOf(currentWord);
                    occurrence[currentWordIndex]++;
                }
            }
            
            //sorting
            for (int i = 0; i < occurrence.Count - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (occurrence[j] > occurrence[j - 1]) 
                    {
                        var temp = occurrence[j];
                        occurrence[j] = occurrence[j - 1]; 
                        occurrence[j - 1] = temp; 

                        var tempWord = words[j];
                        words[j] = words[j - 1];
                        words[j - 1] = tempWord;
                    }
                    j--;
                }
            }

            var wordsRotate = 0;
            foreach (var item in occurrence)
            {
                double percentOccurence = ((double)item / text.Count) * 100d;
                Console.WriteLine($"{words[wordsRotate]} -> {item} times ({percentOccurence:F2}%)");
                wordsRotate++;
            }
        }
    }
}
