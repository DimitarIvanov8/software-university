/*
Extract all quotations from a given text.The text will be on a single line.
A valid quotation should:
•	Start and end with either single quotes (valid: 'quotation') or double quotes(valid: "quotation")
•	Not have mixed quotes(invalid: 'quotation")
Skip nested quotations.

Example input:
<a href='/' id="home">Home</a><a class="selected"</a><a href = '/forum'>

Output:
/
home
selected
/forum
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.Extract_Quotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();

            Regex patern = new Regex(@"("".+?"")|('.+?')");

            MatchCollection matches = patern.Matches(inputText);

            foreach (Match item in matches)
            {
                var word = item.Value.ToString();
                Console.WriteLine(word.Substring(1, (word.Length - 2)));
            }
        }
    }
}
