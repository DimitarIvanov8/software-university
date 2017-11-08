using System;
using Introduction_to_Entity_Framework.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Linq;

namespace Introduction_to_Entity_Framework
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniDbContext();
            using (context)
            {
                var projects = context.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Select(p => new
                    {
                        p.Name,
                        p.Description,
                        p.StartDate
                    })
                    .Take(10)
                    .OrderBy(p => p.Name)
                    .ToList();

                foreach (var pr in projects)
                {
                    Console.WriteLine($"{pr.Name}");
                    Console.WriteLine($"{pr.Description}");
                    Console.WriteLine($"{pr.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)}");
                }      
            }
        }
    }
}
