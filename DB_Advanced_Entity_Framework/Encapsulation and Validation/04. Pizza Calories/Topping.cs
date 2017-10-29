using System;

public class Topping
{
    private string toppingType;
    private double toppingWeight;
    private const double toppingCaloriesPerGram = 2;
    private const double meatModifier = 1.2;
    private const double veggiesModifier = 0.8;
    private const double cheesyModifier = 1.1;
    private const double sauceModifier = 0.9;
    private double toppingTypeCalories;

    public Topping(string type, double weight)
    {
        this.ToppingType = type;
        this.ToppingWeight = weight;
    }

    public string ToppingType
    {
        get
        {
            return this.toppingType;
        }
        private set
        {
            if (value.ToLower() == "meat" || value.ToLower() == "veggies" || 
                value.ToLower() == "cheese" || value.ToLower() == "sauce")
            {
                this.toppingType = value;
            }
            else
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
        }
    }

    public double ToppingWeight
    {
        get
        {
            return this.toppingWeight;
        }
        private set
        {
            if (value > 0 && value <= 50)
            {
                this.toppingWeight = value;
            }
            else
	        {
                throw new ArgumentException($"{this.toppingType} weight should be in the range [1..50].");
            }
        }
    }

    public double TotalCalories()
    {
        switch (toppingType.ToLower())
        {
            case "meat": toppingTypeCalories = meatModifier; break;
            case "veggies": toppingTypeCalories = veggiesModifier; break;
            case "cheese": toppingTypeCalories = cheesyModifier; break;
            case "sauce": toppingTypeCalories = sauceModifier; break;
            default:
                break;
        }
        double totalCalories = (toppingCaloriesPerGram * this.toppingWeight) * toppingTypeCalories;
        return totalCalories;
    }
}

