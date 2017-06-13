/*
Write a program that takes a text and a string of banned words. All words included 
in the ban list should be replaced with asterisks "*", equal to the word's length. 
The entries in the ban list will be separated by a comma and space ", ". The ban list 
should be entered on the first input line and the text on the second input line. 
*/

using System;
using System.Linq;

namespace _9.Text_Filter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            //text = filter.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));
            foreach (var banWord in filter)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
