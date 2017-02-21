using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Track_Downloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blackList = Console.ReadLine()
                .Split(' ')
                .ToList();

            bool end = false;
            bool isValid = true;
            var currentFile = "";

            var fileNames = new List<string>();

            do
            {
                currentFile = Console.ReadLine();

                if (currentFile == "end")
                {
                    end = true;
                    continue;
                }

                for (int i = 0; i < blackList.Count; i++)
                {
                    if (currentFile.Contains(blackList[i]))
                    {
                        isValid = false;
                        continue;                       
                    }
                }

                if (isValid == true)
                {
                    fileNames.Add(currentFile);
                    isValid = false;
                }
                isValid = true;
            } while (end == false);

            fileNames.Sort();

            foreach (var item in fileNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
