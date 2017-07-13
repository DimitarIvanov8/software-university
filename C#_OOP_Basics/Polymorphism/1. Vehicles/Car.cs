public class Car : Vehicle
{
    public Car(double fuelQuantity, double litersPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = litersPerKm;
    }

    public override double FuelQuantity
    {
        get { return base.FuelQuantity; }
        set { base.FuelQuantity = value; }     
    }

    public override double FuelConsumption
    {
        get { return base.FuelConsumption; }
        set
        {
            base.FuelConsumption = value + 0.9;
        }
    }

    public override void Drive(string vehicle, double distance)
    {
        base.Drive(vehicle, distance);
    }

    public override void Refuel(double refueled)
    {
        this.FuelQuantity += refueled;
    }
}

