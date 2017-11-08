using System;
using Introduction_to_Entity_Framework.Data.Models;
using Microsoft.EntityFrameworkCore;
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
                var employee = context.Employees
                    .Include(e => e.EmployeesProjects)
                    .ThenInclude(e => e.Project)
                    .FirstOrDefault(e => e.EmployeeId == 147);

                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                foreach (var project in employee.EmployeesProjects.OrderBy(p => p.Project.Name))
                {
                    Console.WriteLine(project.Project.Name);
                }
            }
        }
    }
}
