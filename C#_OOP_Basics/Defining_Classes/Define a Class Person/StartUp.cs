/*
Create class Person with fields name and age.Create a class Family. The class should have list 
of people, method for adding members(void AddMember(Person member)) and a method returning the 
oldest family member(Person GetOldestMember()). Write a program that reads name and age for 
N people and add them to the family.Then print the name and age of the oldest member.

Example input:
5
Steve 10
Christopher 15
Annie 4
Ivan 35
Maria 34

output:
Ivan 35
*/

using System;
using System.Reflection;

namespace Define_a_Class_Person
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numberOfPeople = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var personInfo = Console.ReadLine().Split(' ');
                var personName = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                Person currentPerson = new Person(personAge, personName);
                family.AddMember(currentPerson);
            }

            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
