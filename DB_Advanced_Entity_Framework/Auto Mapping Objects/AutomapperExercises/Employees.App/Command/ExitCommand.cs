using System;

namespace Employees.App.Command
{
    class ExitCommand : ICommand
    {
        public string Execute(params string[] args)
        {
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);

            return string.Empty;
        }
    }
}
