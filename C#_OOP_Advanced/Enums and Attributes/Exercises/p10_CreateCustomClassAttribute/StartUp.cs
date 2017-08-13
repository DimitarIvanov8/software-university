namespace p10_CreateCustomClassAttribute
{
    using System;
    using System.Linq;
    using Attributes;
    using Models;

    public class StartUp
    {
        public static void Main()
        {
            var customAttribute = (CustomClassAttribute)typeof(Weapon).GetCustomAttributes(false).First();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"{command}: {customAttribute.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"{command}: {customAttribute.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {customAttribute.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"{command}: {string.Join(", ", customAttribute.Reviewers)}");
                        break;
                }

            }
        }
    }
}
