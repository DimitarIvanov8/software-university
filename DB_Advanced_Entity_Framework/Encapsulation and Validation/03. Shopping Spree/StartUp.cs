using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var peopleInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var productsInput = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        var listOfPeople = new List<Person>();
        var listOfProducts = new List<Product>();
        var peopleCannotAfford = new List<string>();

        try
        {
            if (peopleInput.Count() % 2 != 0 || productsInput.Count() % 2 != 0)
            {
                throw new ArgumentException("Name cannot be empty");
            }
            for (int i = 0; i < peopleInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    var personName = peopleInput[i];
                    var money = decimal.Parse(peopleInput[i + 1]);
                    var person = new Person(personName, money);
                    listOfPeople.Add(person);
                }
            }
            for (int i = 0; i < productsInput.Length; i++)
            {
                if (i % 2 == 0)
                {
                    var productName = productsInput[i];
                    var productPrice = decimal.Parse(productsInput[i + 1]);
                    var product = new Product(productName, productPrice);
                    listOfProducts.Add(product);
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var tokens = command.Split().ToArray();
                var personName = tokens[0];
                var product = tokens[1];
                string currentProduct = listOfProducts
                    .First(p => p.Name == product)
                    .Name;
                decimal currentProductPrice = listOfProducts
                    .First(p => p.Name == product)
                    .Price;

                bool canAffordProduct = listOfPeople
                    .First(p => p.Name == personName)
                    .CanAffordProduct(currentProductPrice);
                if (canAffordProduct) //buys product
                {
                    listOfPeople
                        .First(p => p.Name == personName)
                        .BuyProduct(currentProduct, currentProductPrice);

                    Console.WriteLine($"{personName} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{personName} can't afford {product}");
                }
            }
            foreach (var person in listOfPeople)
            {
                var currentBagOfProducts = person.ReturnProducts();
                if (currentBagOfProducts.Count != 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", currentBagOfProducts)}");
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

