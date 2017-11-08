using System;
using Introduction_to_Entity_Framework.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace P02_DatabaseFirst
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniDbContext();
            using (context)
            {
                var employees = context.Employees
                    .Where(e => e.FirstName.StartsWith('S') &&
                    e.FirstName.IndexOf('a') == 1)
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                        e.Salary
                    })
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
                }
            }
        }
    }
}
