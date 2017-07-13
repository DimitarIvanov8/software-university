public static class Validator
{
    public static double FuelQuantityAfterTravel(double fuelAmount, double fuelConsumption, double distance)
    {
        var fuelCheck = fuelAmount - (distance * fuelConsumption);

        return fuelCheck;
    }
}

