using System;
using System.Collections.Generic;

public class CoffeeMachine
{
    private int reseivedCoins;
    private IList<CoffeeType> orders;

    public CoffeeMachine()
    {
        this.orders = new List<CoffeeType>();
    }

    public IEnumerable<CoffeeType> CoffeesSold => this.orders as IReadOnlyCollection<CoffeeType>;

    public void BuyCoffee(string size, string type)
    {
        CoffeePrice coffeePrice = (CoffeePrice)Enum.Parse(typeof(CoffeePrice), size);
        CoffeeType coffeeType = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        int requiredMoney = (int)coffeePrice;

        if (this.reseivedCoins < requiredMoney)
        {
            return;
        }

        this.reseivedCoins = 0;
        this.orders.Add(coffeeType);
    }

    public void InsertCoin(string coin)
    {
        Coin currentCoins = (Coin)Enum.Parse(typeof(Coin), coin);
        this.reseivedCoins += (int)currentCoins;
    }
}