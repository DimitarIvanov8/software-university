using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            //Root -> Filename : File size
            Dictionary<string, Dictionary<string, long>> filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            //File Name : File Extension
            Dictionary<string, string> filesWithExtension = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] inputParams = Console.ReadLine().Split('\\');

                var root = inputParams[0];

                string[] fileParams = inputParams[inputParams.Length - 1]
                    .Split(';');

                string fileNameWithExtension = fileParams[0];
                long fileSize = long.Parse(fileParams[1]);

                string fileName = fileNameWithExtension;
                string fileExtension = fileNameWithExtension.Split('.').Last();

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, long>();
                }

                filesByRoot[root][fileName] = fileSize;
                filesWithExtension[fileName] = fileExtension;
            }

            string[] queryParams = Console.ReadLine()
                .Split(' ');

            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];

            Dictionary<string, long> extractedFiles = new Dictionary<string, long>();

            if (filesByRoot.ContainsKey(queryRoot))
            {
                foreach (var file in filesByRoot[queryRoot])
                {
                    if (filesWithExtension[file.Key] == queryExtension)
                    {
                        extractedFiles[file.Key] = file.Value;
                    }
                }
            }
            if (extractedFiles.Count > 0)
            {
                foreach (var file in extractedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
