using System;

public class Dough
{
    private string flourType;
    private string bakingTechnique;
    private double weight;
    private const double baseCaloriesPerGram = 2;
    private const double whiteModifier = 1.5;
    private const double wholegrainModifier = 1.0;
    private const double crispyModifier = 0.9;
    private const double chewyModifier = 1.1;
    private const double homemadeModifier = 1.0;
    private double flourTypeCalories;
    private double bakingTechniqueCalories;

    public Dough(string flourType, string backingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = backingTechnique;
        this.Weight = weight; 
    }

    public string FlourType
    {
        get
        {
            return this.flourType;
        }
        private set
        {
            if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
            {
                this.flourType = value;
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
    }

    public string BakingTechnique
    {
        get
        {
            return this.bakingTechnique;
        }
        private set
        {
            if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
            {
                this.bakingTechnique = value;
            }
            else
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
    }

    public double Weight
    {
        get
        {
            return this.weight;
        }
        private set
        {
            if (value > 0 && value <= 200)
            {
                this.weight = value;
            }
            else
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
        }
    }

    public double TotalCalories()
    {
        switch (flourType.ToLower())
        {
            case "white": flourTypeCalories = whiteModifier; break;
            case "wholegrain": flourTypeCalories = wholegrainModifier; break;              
            default:
                break;
        }
        switch (bakingTechnique.ToLower())
        {
            case "crispy": bakingTechniqueCalories = crispyModifier; break;
            case "chewy": bakingTechniqueCalories = chewyModifier; break;
            case "homemade": bakingTechniqueCalories = homemadeModifier; break;
            default:
                break;
        }
        var totalCalories = (baseCaloriesPerGram * this.weight) * this.flourTypeCalories * this.bakingTechniqueCalories;
        return totalCalories;
    }
}

