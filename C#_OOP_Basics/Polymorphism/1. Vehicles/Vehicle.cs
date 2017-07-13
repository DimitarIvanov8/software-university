using System;

public abstract class Vehicle
{
    private double fuelQuantity;
    private double fuelConsumption;

    public virtual double FuelQuantity
    {
        get { return this.fuelQuantity; }
        set { this.fuelQuantity = value; }
    }

    public virtual double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }

    public abstract void Refuel(double refueled);
    public virtual void Drive(string vehicle, double distance)
    {
        var fuelAfterTravel = Validator.FuelQuantityAfterTravel(this.FuelQuantity, this.FuelConsumption, distance);

        if (fuelAfterTravel < 0)
        {
            Console.WriteLine($"{vehicle} needs refueling");
        }
        else
        {
            Console.WriteLine($"{vehicle} travelled {distance} km");
            this.FuelQuantity = fuelAfterTravel;
        }
    }
}

