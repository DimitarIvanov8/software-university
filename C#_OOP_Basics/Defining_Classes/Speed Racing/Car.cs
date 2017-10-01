using System;
using System.Collections.Generic;
using System.Linq;

class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionFor1Km;
    private double distanceTraveled;
    private List<Car> listOfCars = new List<Car>();

    public void AddCar(Car car)
    {
        this.listOfCars.Add(car);
    }

    public void CanMoveThatDistance(string model, double amountOfKm)
    {
        Car currentCar = listOfCars.Where(x => x.Model == model).ToList().First();

        double maxDist = currentCar.FuelAmount / currentCar.FuelConsumptionFor1Km;
        double fuelUsed = amountOfKm * currentCar.FuelConsumptionFor1Km;

        if (maxDist >= amountOfKm)
        {
            currentCar.FuelAmount -= fuelUsed;
            currentCar.DistanceTraveled += amountOfKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public void PrintCars()
    {
        foreach (var car in this.listOfCars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.distanceTraveled}");
        }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelConsumptionFor1Km
    {
        get { return this.fuelConsumptionFor1Km; }
        set { this.fuelConsumptionFor1Km = value; }
    }

    public double DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }
}

