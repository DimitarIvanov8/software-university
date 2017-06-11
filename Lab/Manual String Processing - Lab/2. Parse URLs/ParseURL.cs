using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Parse_URLs
{
/*
Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
URL is invalid if:
•	The protocol separator(://) or the resource separator is missing (/)
•	Contains second time the protocol separator ://

Example input: 
https://softuni.bg/courses/csharp-advanced
*/
    class ParseURL
    {
        static void Main(string[] args)
        {
            var url = Console.ReadLine();

            var separator = "://";

            var urlTokens = url.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);

            if (urlTokens.Length != 2 || !urlTokens[1].Contains('/'))
            {
                Console.WriteLine("Invalid URL");
                return; 
            }
            else
            {
                var protocol = urlTokens[0];
                var indexResource = urlTokens[1].IndexOf('/');
                var server = urlTokens[1].Substring(0, indexResource);
                var resource = urlTokens[1].Substring(indexResource + 1);
           
                Console.WriteLine($"Protocol = {protocol}");
                Console.WriteLine($"Server = {server}");
                Console.WriteLine($"Resources = {resource}");
            }
        }
    }
}
