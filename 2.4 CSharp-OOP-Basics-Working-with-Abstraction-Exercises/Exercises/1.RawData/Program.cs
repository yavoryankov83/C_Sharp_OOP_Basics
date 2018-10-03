using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var cars = GetCars();
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        var command = Console.ReadLine();

        if (command == "fragile")
        {
            var fragile = cars
            .Where(c => c.Cargo.CargoType == "fragile" && c.Tires.Any(t => t.TirePressure < 1))
            .Select(c => c.Model)
            .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }
        else
        {
            var flamable = cars
            .Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250)
            .Select(c => c.Model)
            .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }
    }

    private static List<Car> GetCars()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = carInfo[0];

            var engineSpeed = double.Parse(carInfo[1]);
            var enginePower = double.Parse(carInfo[2]);

            var engine = new Engine(engineSpeed, enginePower);

            var cargoWeight = double.Parse(carInfo[3]);
            var cargoType = carInfo[4];

            var cargo = new Cargo(cargoWeight, cargoType);

            var tire1Pressure = double.Parse(carInfo[5]);
            var tire1age = int.Parse(carInfo[6]);
            var tire2Pressure = double.Parse(carInfo[7]);
            var tire2age = int.Parse(carInfo[8]);
            var tire3Pressure = double.Parse(carInfo[9]);
            var tire3age = int.Parse(carInfo[10]);
            var tire4Pressure = double.Parse(carInfo[11]);
            var tire4age = int.Parse(carInfo[12]);

            var tires = new List<Tires>
            {
                new Tires(tire1Pressure, tire1age),
                new Tires(tire2Pressure, tire2age),
                new Tires(tire3Pressure, tire3age),
                new Tires(tire4Pressure, tire4age),
            };

            cars.Add(new Car(model, engine, cargo, tires));
        }

        return cars;
    }
}

