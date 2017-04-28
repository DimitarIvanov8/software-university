using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Hornet_Comm
{
    class HornetComm
    {
        static void Main(string[] args)
        {
            var messageRecipient = new List<string>();
            var messagesText = new List<string>();

            var broadcastFrequency = new List<string>();
            var broadcastText = new List<string>();

            var line = Console.ReadLine();

            while (line != "Hornet is Green")
            {
                string[] inputParams = line.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputParams.Length != 2)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var leftPart = inputParams[0];
                var rightPart = inputParams[1];

                if (leftPart.All(char.IsDigit) && (rightPart.All(char.IsLetterOrDigit)))
                {
                    //message
                    var currentRecipient = new string(leftPart.Reverse().ToArray());
                    var currentText = rightPart;

                    messageRecipient.Add(currentRecipient);
                    messagesText.Add(currentText);
                }
                else if (leftPart.All(s => !char.IsDigit(s)) && (rightPart.All(char.IsLetterOrDigit)))
                {
                    //broadcast
                    var frequency = rightPart;
                    var reversedFrequency = new StringBuilder();

                    foreach (var @char in frequency)
                    {
                        if (char.IsLower(@char))
                        {
                            reversedFrequency.Append(@char.ToString().ToUpper());
                        }
                        else if (char.IsUpper(@char))
                        {
                            reversedFrequency.Append(@char.ToString().ToLower());
                        }
                        else
                        {
                            reversedFrequency.Append(@char);
                        }
                    }

                    var currentText = leftPart;
                    broadcastFrequency.Add(string.Join("", reversedFrequency));
                    broadcastText.Add(currentText);
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            if (broadcastFrequency.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < broadcastFrequency.Count; i++)
                {
                    Console.WriteLine($"{broadcastFrequency[i]} -> {broadcastText[i]}");
                }
            }

            Console.WriteLine("Messages:");
            if (messagesText.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                for (int i = 0; i < messageRecipient.Count; i++)
                {
                    Console.WriteLine($"{messageRecipient[i]} -> {messagesText[i]}");
                }
            }
        }
    }
}
