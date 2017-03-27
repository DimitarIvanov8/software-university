using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2.Line_Numbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("input.txt");
            List<string> inputLines = new List<string>();
            var counter = 1;

            for (int i = 0; i < fileLines.Length; i++)
            {
                inputLines.Add($"{counter}. {fileLines[i]}");
                counter++;
            }

            File.WriteAllText("output.txt", String.Join(Environment.NewLine, inputLines));
        }
    }
}
