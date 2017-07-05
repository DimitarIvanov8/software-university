/*
Read person with their names, age and salary.Read percent bonus 
to every person salary.Persons younger than 30 get half bonus.

•	Names must be at least 3 symbols
•	Age must not be zero or negative
•	Salary can't be less than 460.0 

Print proper message to end user(look at example for messages). 
Use ArgumentExeption with messages from example.

Example input:
5
Asen Ivanov -6 2200
B Borisov 57 3333
Ventsislav Ivanov 27 600
Asen H 44 666.66
Boiko Angelov 35 300
20

Output:
Age cannot be zero or negative integer
First name cannot be less than 3 symbols
Last name cannot be less than 3 symbols
Salary cannot be less than 460 leva
Ventsislav Ivanov get 660.0 leva
*/

using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], 
                                        cmdArgs[1], 
                                        int.Parse(cmdArgs[2]),
                                        double.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        var bonus = double.Parse(Console.ReadLine());
        persons.ForEach(p => p.IncreaseSalary(bonus));
        persons.ForEach(p => Console.WriteLine(p.ToString()));
    }
}

