using System;
using Introduction_to_Entity_Framework.Data.Models;
using Introduction_to_Entity_Framework.Data;
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
                Project projectToRemove = context.Projects.Find(2);

                var pplOnDeletedProject = context.Employees
                    .Include(e => e.EmployeesProjects)
                    .ThenInclude(e => e.Project)
                    .ToList();


                foreach (var employee in pplOnDeletedProject)
                {
                    foreach (var ep in employee.EmployeesProjects.ToList())
                    {
                        if (ep.Project.Equals(projectToRemove))
                        {
                            context.EmployeesProjects.Remove(ep);
                        }
                    }              
                }

                context.Projects.Remove(projectToRemove);
                context.SaveChanges();

                var projects = context.Projects.Take(10).ToList();
                foreach (var p in context.Projects.Take(10))
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
