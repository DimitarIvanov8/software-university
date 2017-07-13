using System;

class StartUp
{
    static void Main(string[] args)
    {
        var carInfo = Console.ReadLine().Split(' ');
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

        var truckInfo = Console.ReadLine().Split(' ');
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        var numberOfCommands = int.Parse(Console.ReadLine());
        var currentCommand = Console.ReadLine().Split(' ');

        for (int i = 0; i < numberOfCommands; i++)
        {
            double distance = double.Parse(currentCommand[2]);
            
            switch (currentCommand[0])
            {
                case "Drive":
                    if (currentCommand[1] == "Car") //drive car
                    {
                        car.Drive(currentCommand[1], double.Parse(currentCommand[2]));
                    }
                    else if (currentCommand[1] == "Truck") //drive truck
                    {
                        truck.Drive(currentCommand[1], double.Parse(currentCommand[2]));
                    }
                    break;
                case "Refuel":
                    if (currentCommand[1] == "Car") //refuel car
                    {
                        car.Refuel(double.Parse(currentCommand[2]));
                    }
                    else if (currentCommand[1] == "Truck") //refuel truck
                    {
                        truck.Refuel(double.Parse(currentCommand[2]));
                    }
                    break;
                default:
                    break;
            }

            if (i == numberOfCommands - 1)
            {
                Console.WriteLine($"Car: {car.FuelQuantity:f2}");
                Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
                break;
            }          

            currentCommand = Console.ReadLine().Split(' ');
        }
    }
}

