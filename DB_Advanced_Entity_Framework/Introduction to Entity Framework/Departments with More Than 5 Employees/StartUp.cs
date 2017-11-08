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
                var departments = context.Departments
                    .Where(d => d.Employees.Count > 5)
                    .OrderBy(e => e.Employees.Count)
                    .ThenBy(d => d.Name)
                    .Select(d => new
                    {
                        d.Name,
                        d.Manager,
                        d.Employees
                    })
                    .ToList();

                foreach (var dep in departments)
                {
                    Console.WriteLine($"{dep.Name} - {dep.Manager.FirstName} {dep.Manager.LastName}");
                    foreach (var employee in dep.Employees
                        .OrderBy(e => e.FirstName)
                        .ThenBy(e => e.LastName))
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                    }
                    Console.WriteLine("----------");
                }      
            }
        }
    }
}
