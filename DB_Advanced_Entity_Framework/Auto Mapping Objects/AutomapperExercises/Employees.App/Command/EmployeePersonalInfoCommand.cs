using Employees.Services;
using Employees.DtoModels;
using System;

namespace Employees.App.Command
{
    class EmployeePersonalInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeePersonalInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<employeeId>
        public string Execute(params string[] args)
        {
            int employeeId = int.Parse(args[0]);

            var employee = employeeService.PersonalById(employeeId);

            string birthday = "[no birthday specified]";
            if (employee.Birthday != null)
            {
                birthday = employee.Birthday.Value.ToString("dd-MM-yyyy");
            }         

            string address = employee.Address ?? "[no address specified]";
            var result = $"ID: {employeeId} - {employee.FirstName} {employee.LastName} - ${employee.Salary:f2} " 
                + Environment.NewLine +
                $"Birthday: {birthday}" + 
                Environment.NewLine +
                $"Address: {address}";

            return result;
        }
    }
}
