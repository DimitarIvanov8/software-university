using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        try
        {
            string pizzaName = string.Empty;
            string flourType = string.Empty;
            string backingTechnique = string.Empty;
            double doughWeight = 0.0;
            var pizzaToppings = new List<Topping>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var tokens = line.Split();
                if (tokens[0] == "Dough")
                {
                    if (tokens.Length != 4)
                    {
                        throw new ArgumentException("Invalid type of dough.");
                    }
                    flourType = tokens[1];
                    backingTechnique = tokens[2];
                    doughWeight = double.Parse(tokens[3]);
                }
                else if (tokens[0] == "Topping")
                {
                    if (tokens.Length != 3)
                    {
                        throw new ArgumentException("Number of toppings should be in range [0..10].");
                    }
                    var toppingType = tokens[1];
                    var weight = double.Parse(tokens[2]);
                    var currentTopping = new Topping(toppingType, weight);
                    pizzaToppings.Add(currentTopping);
                }
                else if (tokens[0] == "Pizza")
                {
                    if (tokens.Length != 2)
                    {
                        throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                    }
                    pizzaName = tokens[1];
                }
            }
            var currentDough = new Dough(flourType, backingTechnique, doughWeight);
            Pizza pizza = new Pizza(pizzaName, currentDough);

            if (pizzaToppings.Count != 0)
            {
                foreach (var topping in pizzaToppings)
                {
                    pizza.AddTopping(topping);
                }
            }
            Console.WriteLine($"{pizza.PizzaName} - {pizza.TotalCalories():f2} Calories.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

