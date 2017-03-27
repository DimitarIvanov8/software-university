using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5.Folder_Size
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] fileNames = Directory.GetFiles("../../TestFolder");

            double sumSize = 0;

            foreach (var file in fileNames)
            {
                FileInfo fileInfo = new FileInfo(file);
                sumSize += fileInfo.Length;
            }

            File.WriteAllText("../../output.txt", (sumSize / 1024 / 1024) + " MB");
        }
    }
}
