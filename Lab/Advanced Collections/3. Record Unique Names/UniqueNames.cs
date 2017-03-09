using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Record_Unique_Names
{
    class UniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(String.Join(Environment.NewLine,names));
        }
    }
}
