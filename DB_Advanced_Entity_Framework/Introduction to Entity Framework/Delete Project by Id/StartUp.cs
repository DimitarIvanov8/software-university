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
                var pplOnDeletedProject = context.EmployeesProjects
                    .Where(ep => ep.Project == projectToRemove);

                foreach (var ep in pplOnDeletedProject)
                {
                    context.EmployeesProjects.Remove(ep);
                }

                context.Projects.Remove(projectToRemove);
                context.SaveChanges();

                var projects = context.Projects.Take(10).ToList();
                foreach (var p in projects)
                {
                    Console.WriteLine(p.Name);
                }
            }
        }
    }
}
