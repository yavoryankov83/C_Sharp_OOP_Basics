using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var cars = new List<Car>();

        var inputedCars = GetCars();
        DriveCars(inputedCars);
        PrintCars(inputedCars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceToGO}");
        }
    }

    private static void DriveCars(List<Car> cars)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split();

            var currCar = cars.Where(c => c.Model == tokens[1]).FirstOrDefault();

            if (currCar != null)
            {
                currCar.Drive(double.Parse(tokens[2]));
            }
        }
    }

    private static List<Car> GetCars()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            cars.Add(new Car(input[0], double.Parse(input[1]), double.Parse(input[2])));
        }

        return cars;
    }
}

