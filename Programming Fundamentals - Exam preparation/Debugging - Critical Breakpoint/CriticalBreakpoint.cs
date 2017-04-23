using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Debugging___Critical_Breakpoint
{
    class Line
    {
        public BigInteger X1 { get; set; }

        public BigInteger Y1 { get; set; }

        public BigInteger X2 { get; set; }

        public BigInteger Y2 { get; set; }

        public BigInteger CriticalRatio { get; set; }
    }

    class CriticalBreakpoint
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            List<Line> lines = new List<Line>();

            while (inputLine != "Break it.")
            {
                BigInteger[] lineParams = inputLine.Split().Select(BigInteger.Parse).ToArray();

                Line line = new Line()
                {
                    X1 = lineParams[0],
                    Y1 = lineParams[1],
                    X2 = lineParams[2],
                    Y2 = lineParams[3],
                    CriticalRatio = BigInteger.Abs((lineParams[2] + lineParams[3]) - (lineParams[1] + lineParams[0]))
                };

                lines.Add(line);

                inputLine = Console.ReadLine();
            }

            bool hasBreakpoint = true;
            BigInteger actualRatio = lines[0].CriticalRatio;

            foreach (Line line in lines)
            {
                if (actualRatio == 0 && line.CriticalRatio != 0)
                {
                    actualRatio = line.CriticalRatio;
                }

                if (line.CriticalRatio != actualRatio && line.CriticalRatio != 0)
                {
                    hasBreakpoint = false;
                    break;
                }   
            }

            if (hasBreakpoint)
            {
                BigInteger totalRatio = BigInteger.Pow(actualRatio, lines.Count);

                BigInteger criticalBreakpoint = 0;

                BigInteger.DivRem(totalRatio, lines.Count, out criticalBreakpoint);

                foreach (var line in lines)
                {
                    Console.WriteLine("Line: [{0}, {1}, {2}, {3}]", 
                        line.X1, line.Y1, line.X2, line.Y2);
                }

                Console.WriteLine("Critical Breakpoint: {0}", criticalBreakpoint);
            }
            else
            {
                Console.WriteLine("Critical breakpoint does not exist.");
            }
        }
    }
}
