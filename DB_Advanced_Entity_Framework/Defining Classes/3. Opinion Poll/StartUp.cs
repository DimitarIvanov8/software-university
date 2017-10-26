using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var linesOfPersonalInfo = int.Parse(Console.ReadLine());
        var listOfPeople = new List<Person>();

        for (int i = 0; i < linesOfPersonalInfo; i++)
        {
            var currentLine = Console.ReadLine();
            var inputParams = currentLine.Split().ToList();
            var name = inputParams[0];
            var age = int.Parse(inputParams[1]);

            var currentPerson = new Person(name, age);
            listOfPeople.Add(currentPerson);
        }

        foreach (var person in listOfPeople.Where(p => p.Age > 30).OrderBy(p => p.Name))
        {
            Console.WriteLine(person);
        }
    }
}

