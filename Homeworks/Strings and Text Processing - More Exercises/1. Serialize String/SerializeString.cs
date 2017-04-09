using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Serialize_String
{
    class SerializeString
    {
        static void Main(string[] args)
        {
            var index = -2;
            int count = 0;
            string input = Console.ReadLine();
            string output = "";
            var Array = input.ToCharArray();
            for (int i = 0; i < Array.Length; i++)
            {
                if (!output.Contains(Array[i]))
                {
                    output += Array[i];
                    output += ":";

                    for (int j = 0; j < Array.Length; j++)
                    {
                        count = input.IndexOf(Array[i], j);
                        if (count != -1 && count != index)
                        {
                            output += count;
                            output += "/";
                        }
                        index = count;
                    }
                    index = 0;
                    output = output.Remove(output.Length - 1);
                    output += Environment.NewLine;
                }
            }
            Console.WriteLine(output);
        }
    }
}
