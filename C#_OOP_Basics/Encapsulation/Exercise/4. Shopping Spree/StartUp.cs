/*
Create two classes: class Person and class Product. Each person should have a name, money and a bag of products. 
Each product should have name and cost. Name cannot be an empty string. Money cannot be a negative number. Create 
a program in which each command corresponds to a person buying a product. If the person can afford a product add 
it to his bag. If a person doesn’t have enough money, print an appropriate message ("[Person name] can't afford 
[Product name]"). On the first two lines you are given all people and all products. After all purchases print every 
person in the order of appearance and all products that he has bought also in order of appearance. If nothing is bought
, print the name of the person followed by "Nothing bought". In case of invalid input (negative money exception message: 
"Money cannot be negative") or empty name (empty name exception message: "Name cannot be empty") break the program with 
an appropriate message. See the examples below:

Example input:
Pesho=11;Gosho=4
Bread=10;Milk=2;
Pesho Bread
Gosho Milk
Gosho Milk
Pesho Milk
END

output:
Pesho bought Bread
Gosho bought Milk
Gosho bought Milk
Pesho can't afford Milk
Pesho - Bread
Gosho - Milk, Milk
*/

using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        List<Person> listOfPersons = new List<Person>();
        List<Product> listOfProducts = new List<Product>();
        try
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            string[] peopleInfo = input1.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in peopleInfo)
            {
                string[] splitedPair = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                listOfPersons.Add(new Person(splitedPair[0], decimal.Parse(splitedPair[1])));
            }

            string[] productInfo = input2.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var p in productInfo)
            {
                string[] splitedPair = p.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                listOfProducts.Add(new Product(splitedPair[0], decimal.Parse(splitedPair[1])));
            }

            string input3 = Console.ReadLine();
            while (input3 != "END")
            {
                string[] inputParams = input3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person.BuyProduct(inputParams[0], inputParams[1], listOfPersons, listOfProducts);

                input3 = Console.ReadLine();
            }

            foreach (var person in listOfPersons)
            {
                if (person.Bag.Count > 0)
                {
                    Console.Write($"{person.Name} - ");

                    for (int i = 0; i < person.Bag.Count - 1; i++)
                    {
                        Console.Write($"{person.Bag[i].Name}, ");
                    }

                    Console.WriteLine(person.Bag[person.Bag.Count - 1].Name);
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

