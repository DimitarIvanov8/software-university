using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var numberOfCars = int.Parse(Console.ReadLine());
        var listOfCars = new Dictionary<string, Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var tokens = Console.ReadLine().Split().ToList();
            var model = tokens[0];
            var fuelAmount = decimal.Parse(tokens[1]);
            var fuelConsumption = decimal.Parse(tokens[2]);

            var currentCar = new Car(model, fuelAmount, fuelConsumption);

            if (!listOfCars.ContainsKey(model))
            {
                listOfCars[model] = new Car(model, fuelAmount, fuelConsumption);
            }
        }

        var command = Console.ReadLine();

        while (command != "End")
        {
            var tokens = command.Split().ToList();
            var model = tokens[1];
            var distance = decimal.Parse(tokens[2]);

            if (listOfCars.ContainsKey(model))
            {
                listOfCars[model].DriveIfPossible(model, distance);
            }
            command = Console.ReadLine();
        }

        foreach (var car in listOfCars)
        {
            Console.WriteLine(car.Value);
        }
    }
}