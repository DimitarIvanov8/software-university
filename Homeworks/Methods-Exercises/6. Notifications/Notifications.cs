using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string operation = String.Empty;
            string message = String.Empty;
            int code = 0;

            for (int i = 0; i < n; i++)
            {
                string successOrErrorMessage = Console.ReadLine();
                if (successOrErrorMessage == "success")
                {
                    operation = Console.ReadLine();
                    message = Console.ReadLine();
                    var reason = String.Empty;

                    var printedMessage = ShowSuccess(operation, message);
                    Console.WriteLine(printedMessage);
                }
                else if (successOrErrorMessage == "error")
                {
                    operation = Console.ReadLine();
                    code = int.Parse(Console.ReadLine());
                    //var reason = String.Empty;

                    var printedMessasge = ShowError(operation, code);
                    Console.WriteLine(printedMessasge);
                }
            }
        }

        static string ShowError(string operation, int code)
        {
            var reason = String.Empty;

            if (code >= 0)
            {
                reason = "Invalid Client Data";
            }
            else
            {
                reason = "Internal System Failure";
            }

            var printedMessage = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
            return printedMessage;
        }

        static string ShowSuccess(string operation, string message)
        {
            var printedMessage = $"Successfully executed {operation}.\n==============================\nMessage: {message}.";
            return printedMessage;
        }
    }
}
