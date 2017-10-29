using System;
using System.Collections.Generic;

public class Pizza
{
    private string pizzaName;
    private List<Topping> pizzaToppings;
    private Dough pizzaDough;
    private double totalToppingCalories;
    private double totalDoughCalories;

    public Pizza(string name, Dough dough)
    {
        this.pizzaName = name;
        this.PizzaDough = dough;
        this.pizzaToppings = new List<Topping>();
    }

    public string PizzaName
    {
        get
        {
            return this.pizzaName;
        }
        private set
        {
            if (value.Length <= 15)
            {
                this.pizzaName = value;
            }
            else
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
        }
    }

    public List<Topping> PizzaToppings
    {
        get
        {
            return this.pizzaToppings;
        }
        private set
        {
            this.pizzaToppings = value;
        }
    }

    public Dough PizzaDough
    {
        get
        {
            return this.pizzaDough;
        }
        private set
        {
            this.pizzaDough = value;
        }
    }

    public void AddTopping(Topping topping)
    {
        if (pizzaToppings.Count <= 10)
        {
            pizzaToppings.Add(topping);
        }
        else
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    public double TotalCalories()
    {
        foreach (var topping in pizzaToppings)
        {
            totalToppingCalories += topping.TotalCalories();
        }
        totalDoughCalories = this.pizzaDough.TotalCalories();
        var totalPizzaCalories = totalToppingCalories + totalDoughCalories;
        return totalPizzaCalories;
    }
}

