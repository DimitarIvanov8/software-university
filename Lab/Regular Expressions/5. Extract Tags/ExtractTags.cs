/*
Extract all tags from a given HTML using regex.
Read lines until you get the "END" command.
If there are no tags, don’t print anything.

Example input:
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>Title</title>
</head>
</html>
END

Output:
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>
</title>
</head>
</html>
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Extract_Tags
{
    class ExtractTags
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"<.+?>");
            List<string> tags = new List<string>();

            while (text != "END")
            {
                MatchCollection matches = pattern.Matches(text);

                foreach (Match item in matches)
                {
                    tags.Add(item.Value);
                }

                text = Console.ReadLine();
            }

            foreach (var tag in tags)
            {
                Console.WriteLine(tag);
            }
        }
    }
}
