using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.Odd_Lines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string[] fileLines = File.ReadAllLines("input.txt");

            for (int i = 1; i < fileLines.Length; i += 2)
            {
                File.AppendAllText("output.txt", fileLines[i] + Environment.NewLine);
            }
        }
    }
}
