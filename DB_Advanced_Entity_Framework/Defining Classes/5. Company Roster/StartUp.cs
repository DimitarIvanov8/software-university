using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var numberOfEmployees = int.Parse(Console.ReadLine());
        var employeeList = new List<Employee>();

        for (int i = 0; i < numberOfEmployees; i++)
        {
            var currentEmployeeInfo = Console.ReadLine();
            var tokens = currentEmployeeInfo.Split().ToList();

            var name = tokens[0];
            var salary = decimal.Parse(tokens[1]);
            var position = tokens[2];
            var department = tokens[3];
            var email = "n/a";
            var age = -1;

            if (tokens.Count == 5)
            {
                if (tokens[4].Contains("@"))
                {
                    email = tokens[4];
                }
                else
                {
                    age = int.Parse(tokens[4]);
                }
            }
            else if (tokens.Count == 6)
            {
                email = tokens[4];
                age = int.Parse(tokens[5]);
            }

            var currentEmployee = new Employee(name, salary, position, department, email, age);
            employeeList.Add(currentEmployee);
        }

        decimal highestAvgSalaryOfDepartment = 0;
        string departmentWithHighestAvgSalary = string.Empty;

        foreach (var department in employeeList
            .GroupBy(d => d.Department, s => s.Salary))
        {
            var nameOfDepartment = department.Key;
            var avgSalaryPerDep = department.Average();

            if (avgSalaryPerDep > highestAvgSalaryOfDepartment)
            {
                highestAvgSalaryOfDepartment = avgSalaryPerDep;
                departmentWithHighestAvgSalary = nameOfDepartment;
            }
        }

        Console.WriteLine($"Highest Average Salary: {departmentWithHighestAvgSalary}");
        foreach (var employee in employeeList
            .Where(d => d.Department == departmentWithHighestAvgSalary)
            .OrderByDescending(s => s.Salary))
        {
            Console.WriteLine(employee);
        }
    }
}

