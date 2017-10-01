/*
Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars.
Define a class Car that keeps track of a car’s Model, fuel amount, fuel consumption for 1 kilometer and distance 
traveled.A Car’s Model is unique - there will never be 2 cars with the same model.

On the first line of the input you will receive a number N – the number of cars you need to track, on each of 
the next N lines you will receive information for a car in the following format “<Model> <FuelAmount> 
<FuelConsumptionFor1km>”, all cars start at 0 kilometers traveled.


After the N lines, until the command “End” is received, you will receive a commands in the following format 
“Drive<CarModel>  <amountOfKm>”. Implement a method in the Car class to calculate whether or not a car can 
move that distance, if it can the car’s fuel amount should be reduced by the amount of used fuel and its 
distance traveled should be increased by the amount of kilometers traveled, otherwise the car should not 
move(Its fuel amount and distance traveled should stay the same) and you should print on the console 
“Insufficient fuel for the drive”. After the “End” command is received, print each car and its current fuel 
amount and distance traveled in the format “<Model> <fuelAmount>  <distanceTraveled>”, where the 
fuel amount should be printed to two decimal places after the separator.

Example input:
3
AudiA4 18 0.34
BMW-M2 33 0.41
Ferrari-488Spider 50 0.47
Drive Ferrari-488Spider 97
Drive Ferrari-488Spider 35
Drive AudiA4 85
Drive AudiA4 50
End

Output:
Insufficient fuel for the drive
Insufficient fuel for the drive
AudiA4 1.00 50
BMW-M2 33.00 0
Ferrari-488Spider 4.41 97
*/

using System;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        Car car = new Car();
        var numberOfCars = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCars; i++)
        {
            var carInfo = Console.ReadLine().Split(' ');

            var model = carInfo[0].ToString();
            var fuelAmount = double.Parse(carInfo[1]);
            var FuelConsumptionFor1km = double.Parse(carInfo[2]);
            Car currentCar = new Car
            {
                Model = model,
                FuelAmount = fuelAmount,
                FuelConsumptionFor1Km = FuelConsumptionFor1km
            };

            car.AddCar(currentCar);
        }

        var command = Console.ReadLine().Split(' ');
        while (!command.Contains("End"))
        {
            var driveModel = command[1];
            var driveKm = double.Parse(command[2]);

            car.CanMoveThatDistance(driveModel, driveKm);

            command = Console.ReadLine().Split(' ');
        }

        car.PrintCars();
    }
}
