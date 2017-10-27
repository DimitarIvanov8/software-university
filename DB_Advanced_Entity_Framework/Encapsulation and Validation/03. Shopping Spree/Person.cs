using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<string> bagOfProducts;

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this.BagOfProducts = new List<string>();
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        private set
        {
            this.name = value;
        }
    }

    public decimal Money
    {
        get
        {
            return this.money;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            else
            {
                this.money = value;
            }
        }
    }

    public List<string> BagOfProducts
    {
        get
        {
            return this.bagOfProducts;
        }
        private set
        {
            this.bagOfProducts = value;
        }
    }

    public bool CanAffordProduct(decimal productPrice)
    {
        if (this.money >= productPrice)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void BuyProduct(string product, decimal productPrice)
    {
        this.money -= productPrice;
        this.bagOfProducts.Add(product);
    }

    public int NumberOfProducts()
    {
        return this.bagOfProducts.Count;
    }

    public List<string> ReturnProducts()
    {
        return this.bagOfProducts;
    }
}

