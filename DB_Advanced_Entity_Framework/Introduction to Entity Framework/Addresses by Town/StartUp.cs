using System;
using Introduction_to_Entity_Framework.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;

namespace P02_DatabaseFirst
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniDbContext();
            using (context)
            {
                var employees = context.Addresses
                    .Include(a => a.Employees)
                    .Include(a => a.Town)
                    .OrderByDescending(e => e.Employees.Count())
                    .ThenBy(t => t.Town.Name)
                    .ThenBy(a => a.AddressText)
                    .Take(10)
                    .ToList();

                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.AddressText}, {e.Town.Name} - {e.Employees.Count} employees");
                }
            }
        }
    }
}
