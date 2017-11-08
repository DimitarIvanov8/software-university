using System;
using Introduction_to_Entity_Framework.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
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
                    .Where(e => e.Department.Name == "Engineering" ||
                    e.Department.Name == "Tool Design" ||
                    e.Department.Name == "Marketing" ||
                    e.Department.Name == "Information Services")                   
                    .ToList();

                foreach (var emp in employees
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName))
                {
                    emp.Salary *= 1.12m;
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
                }

                context.SaveChanges();
            }
        }
    }
}
