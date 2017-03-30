using System;
using System.Collections.Generic;
using System.IO;

namespace _1.Filter_Extensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("input");
            var fileExtension = Console.ReadLine();
            var files = new List<string>();

            foreach (var file in fileNames)
            {
                if (file.Contains(fileExtension))
                {
                    files.Add(file);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine,files));
        }
    }
}
