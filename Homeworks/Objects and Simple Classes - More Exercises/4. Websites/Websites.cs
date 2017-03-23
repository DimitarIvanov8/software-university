using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Websites
{
    class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }

    class Websites
    {
        static void Main(string[] args)
        {
            List<Website> sites = new List<Website>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                string[] inputParams = line.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var host = inputParams[0];
                var domain = inputParams[1];
                List<string> queries = inputParams.Skip(2).ToList();
                var newQueries = queries.Select(x => "[" + x + "]").ToList();

                Website newWebsite = new Website
                {
                    Host = host,
                    Domain = domain,
                    Queries = new List<string>(newQueries)
                };

                sites.Add(newWebsite);
                line = Console.ReadLine();
            }

            foreach (var website in sites)
            {
                if (website.Queries.Count != 0)
                {
                    Console.Write("https://www.{0}.{1}/query?=", website.Host, website.Domain);
                    Console.WriteLine(String.Join("&", website.Queries));
                }
                else
                {
                    Console.WriteLine("https://www.{0}.{1}", website.Host, website.Domain);
                }
            }
        }
    }
}
