using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var cars = GetCars();
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        var input = Console.ReadLine();

        Console.WriteLine(string.Join(Environment.NewLine, cars
                        .Where(c => c.Cargo.CargoType == input && input == "fragile"
                            ? c.Tire
                                .Where(t => t.TirePressure < 1)
                                .FirstOrDefault() != null
                            : c.Engine.EnginePower > 250)
                        .Select(c => c.Model)));
    }

    public static List<Car> GetCars()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var model = input[0];
            var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
            var cargo = new Cargo(int.Parse(input[3]), input[4]);
            var tires = new Tire[4]
            {
                 new Tire(double.Parse(input[5]), int.Parse(input[6])),
                 new Tire(double.Parse(input[7]), int.Parse(input[8])),
                 new Tire(double.Parse(input[9]), int.Parse(input[10])),
                 new Tire(double.Parse(input[11]), int.Parse(input[12])),
            };

            cars.Add(new Car(model, engine, cargo, tires));
        }

        return cars;
    }
}

