using System;
using P02_DatabaseFirst.Data;
using System.Linq;

namespace P02_DatabaseFirst
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            var employees = context
                .Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.Salary,
                })
                .Where(e => e.Salary > 50000)
                .OrderBy(e => e.FirstName)
                .ToList();

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName}");
            }
        }
    }
}
