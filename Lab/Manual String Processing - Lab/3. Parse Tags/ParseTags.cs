using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Parse_Tags
{
/*
You are given a text.Write a program that changes the text in all 
regions surrounded by the tags<upcase> and</upcase> to upper-case.
The tags cannot be nested.

Example input: 
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
Output: 
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

    class ParseTags
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var openTag = "<upcase>";
            var closeTag = "</upcase>";

            int startIndex = inputText.IndexOf(openTag);

            while (startIndex != -1)
            {
                var endIndex = inputText.IndexOf(closeTag);
                if (endIndex == -1)
                {
                    break;
                }

                var toBeReplaced = inputText.Substring(startIndex, endIndex + closeTag.Length - startIndex);

                var replaced = toBeReplaced.Replace(openTag, String.Empty)
                    .Replace(closeTag, String.Empty).ToUpper();

                inputText = inputText.Replace(toBeReplaced, replaced);

                startIndex = inputText.IndexOf(openTag);
            }
            Console.WriteLine(inputText);
        }
    }
}
