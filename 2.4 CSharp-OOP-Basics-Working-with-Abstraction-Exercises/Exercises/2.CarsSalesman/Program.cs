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

    private static void PrintCars(Queue<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    private static Queue<Car> GetCars()
    {
        var engines = GetEngines();

        var cars = new Queue<Car>();

        var m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            var inputCars = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var car = new Car(inputCars[0], engines.Where(e => e.Model == inputCars[1]).FirstOrDefault());

            if (inputCars.Length == 3)
            {
                int weight;
                var isInt = int.TryParse(inputCars[2], out weight);

                if (isInt)
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = inputCars[2];
                }
            }
            if (inputCars.Length == 4)
            {
                car.Weight = int.Parse(inputCars[2]);
                car.Color = inputCars[3];
            }

            cars.Enqueue(car);
        }

        return cars;
    }

    private static Stack<Engine> GetEngines()
    {
        var engines = new Stack<Engine>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputEngines = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var engine = new Engine(inputEngines[0], int.Parse(inputEngines[1]));

            engines.Push(engine);

            if (inputEngines.Length == 3)
            {
                int displacement;
                var isInt = int.TryParse(inputEngines[2], out displacement);

                if (isInt)
                {
                    engines.Peek().Displacement = displacement;
                }
                else
                {
                    engines.Peek().Efficiency = inputEngines[2];
                }
            }
            if (inputEngines.Length == 4)
            {
                engines.Peek().Displacement = int.Parse(inputEngines[2]);
                engines.Peek().Efficiency = inputEngines[3];
            }
        }

        return engines;
    }
}

