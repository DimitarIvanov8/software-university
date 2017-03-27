using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4.Merge_Files
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] fileOne = File.ReadAllLines("FileOne.txt");
            string[] fileTwo = File.ReadAllLines("FileTwo.txt");
            List<int> fileContent = new List<int>();

            foreach (var item in fileOne)
            {
                fileContent.Add(int.Parse(item));
            }
            foreach (var item in fileTwo)
            {
                fileContent.Add(int.Parse(item));
            }
            fileContent.Sort();
            File.WriteAllText("output.txt", String.Join("\r\n", fileContent));
        }
    }
}
