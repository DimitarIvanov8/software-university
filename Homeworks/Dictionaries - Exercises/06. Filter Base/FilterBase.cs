using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Filter_Base
{
    class FilterBase
    {
        static void Main(string[] args)
        {
            var nameAndPosition = new Dictionary<string, string>();
            var nameAndSalary = new Dictionary<string, double>();
            var nameAndAge = new Dictionary<string, int>();
            int numInt = 0;
            double numDouble = 0.0;

            string line = Console.ReadLine();

            while (line != "filter base")
            {
                var tokens = line.Split(' ');
                var name = tokens[0];

                bool intParsed = int.TryParse(tokens[2], out numInt);
                bool doubleParse = double.TryParse(tokens[2], out numDouble);

                if (intParsed == true)
                {
                    var age = int.Parse(tokens[2]);
                    nameAndAge[name] = age;
                }
                else if (doubleParse == true)
                {
                    var salary = double.Parse(tokens[2]);
                    nameAndSalary[name] = salary;
                }
                else
                {
                    var position = tokens[2];
                    nameAndPosition[name] = position;
                }

                line = Console.ReadLine();
            }

            var filter = Console.ReadLine();

            if (filter == "Position")
            {
                foreach (var kvp in nameAndPosition)
                {
                    Console.WriteLine($"Name: {kvp.Key}\nPosition: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (filter == "Salary")
            {
                foreach (var kvp in nameAndSalary)
                {
                    Console.WriteLine($"Name: {kvp.Key}\nSalary: {kvp.Value:F2}");
                    Console.WriteLine(new string('=', 20));
                }
            }
            else if (filter == "Age")
            {
                foreach (var kvp in nameAndAge)
                {
                    Console.WriteLine($"Name: {kvp.Key}\nAge: {kvp.Value}");
                    Console.WriteLine(new string('=', 20));
                }
            }
        }
    }
}
