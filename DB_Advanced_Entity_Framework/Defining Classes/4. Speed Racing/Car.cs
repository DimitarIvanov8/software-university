public class Car
{
    public string model { get; set; }
    public decimal fuelAmount { get; set; }
    public decimal fuelConsumptionPerKM  { get; set; }
    public decimal distanceTraveled { get; set; }

    public Car(string model, decimal fuelAmount, decimal fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumptionPerKM = fuelConsumption;
        this.distanceTraveled = 0;
    }

    public void DriveIfPossible(string model, decimal distance)
    {
        var fuelNeeded = distance * fuelConsumptionPerKM;

        if (fuelAmount < fuelNeeded)
        {
            System.Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.fuelAmount -= fuelNeeded;
            this.distanceTraveled += distance;
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
    }
}

