public class Car
{
    public string Model { get; set; }
    public decimal FuelAmount { get; set; }
    public decimal FuelConsumptionPerKM  { get; set; }
    public decimal DistanceTraveled { get; set; }

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKM = fuelConsumption;
        this.DistanceTraveled = 0;
    }

    public void DriveIfPossible(string model, decimal distance)
    {
        var fuelNeeded = distance * FuelConsumptionPerKM;

        if (FuelAmount < fuelNeeded)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmount -= fuelNeeded;
            this.DistanceTraveled += distance;
        }
    }

    public override string ToString()
    {
        return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
    }
}

