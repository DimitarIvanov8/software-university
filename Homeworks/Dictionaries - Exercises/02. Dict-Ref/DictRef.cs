using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class DictRef
    {
        static void Main(string[] args)
        {
            var nameAndValue = new List<string>();
            var namesAndValuesCollection = new Dictionary<string, int>();
            var number = 0;
            var theHolyNumber = 0;

            do
            {
                nameAndValue = Console.ReadLine().Split(' ').ToList();
                if (nameAndValue.Contains("end"))
                {
                    continue;
                }
                bool parsed = int.TryParse(nameAndValue[2], out number);

                if (parsed == false)
                {
                    foreach (var kvp in namesAndValuesCollection)
                    {
                        if (nameAndValue[2] == kvp.Key)
                        {
                            theHolyNumber = kvp.Value;
                        }
                    }
                    if (theHolyNumber != 0)
                    {
                        namesAndValuesCollection[nameAndValue[0]] = theHolyNumber;
                        theHolyNumber = 0;
                    }
                }
                else if (parsed == true)
                {
                    namesAndValuesCollection[nameAndValue[0]] = int.Parse(nameAndValue[2]);
                }

            } while (!nameAndValue.Contains("end"));

            foreach (var kvp in namesAndValuesCollection)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
