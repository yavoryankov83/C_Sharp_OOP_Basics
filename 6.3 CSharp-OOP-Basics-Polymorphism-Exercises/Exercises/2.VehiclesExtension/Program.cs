using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var vehiclesList = GetVehicles();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var commandInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (commandInput[0] == "Drive")
            {
                switch (commandInput[1])
                {
                    case "Car":
                        var car = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Car");
                        car.Drive(double.Parse(commandInput[2]));
                        break;

                    case "Truck":
                        var truck = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Truck");
                        truck.Drive(double.Parse(commandInput[2]));
                        break;

                    case "Bus":
                        var bus = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Bus");
                        bus.Drive(double.Parse(commandInput[2]));
                        break;

                    default:
                        break;
                }
            }
            else if(commandInput[0] == "Refuel")
            {
                switch (commandInput[1])
                {
                    case "Car":
                        var car = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Car");
                        car.ReFuel(double.Parse(commandInput[2]));
                        break;

                    case "Truck":
                        var truck = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Truck");
                        truck.ReFuel(double.Parse(commandInput[2]));
                        break;

                    case "Bus":
                        var bus = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Bus");
                        bus.ReFuel(double.Parse(commandInput[2]));
                        break;

                    default:
                        break;
                }
            }
            else
            {
                var currBus = vehiclesList.FirstOrDefault(v => v.GetType().Name == "Bus");
                Bus bus = (Bus)currBus;
                bus.DriveEmpty(double.Parse(commandInput[2]));
            }
        }

        Console.WriteLine(vehiclesList.FirstOrDefault(v => v.GetType().Name == "Car"));
        Console.WriteLine(vehiclesList.FirstOrDefault(v => v.GetType().Name == "Truck"));
        Console.WriteLine(vehiclesList.FirstOrDefault(v => v.GetType().Name == "Bus"));
    }

    private static List<Vehicle> GetVehicles()
    {
        var vehiclesList = new List<Vehicle>();

        for (int i = 0; i < 3; i++)
        {
            var input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var vehicleType = input[0];

            switch (vehicleType)
            {
                case "Car":
                    var car =  new Car(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                    vehiclesList.Add(car);
                    break;
                case "Truck":
                    var truck =  new Truck(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                    vehiclesList.Add(truck);
                    break;
                case "Bus":
                    var bus =  new Bus(double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
                    vehiclesList.Add(bus);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        return vehiclesList;
    }
}

