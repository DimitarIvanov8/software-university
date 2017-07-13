public class Truck : Vehicle
{
    public Truck(double fuelQuantity, double litersPerKm)
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
            base.FuelConsumption = value + 1.6;
        }
    }

    public override void Drive(string vehicle, double distance)
    {
        base.Drive(vehicle, distance);
    }

    public override void Refuel(double refueled)
    {
        this.FuelQuantity += refueled * 0.95;
    }
}

