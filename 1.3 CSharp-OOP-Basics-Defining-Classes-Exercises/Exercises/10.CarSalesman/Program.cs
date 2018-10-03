using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var engines = GetEngines();
        var cars = GetCars(engines);
        PrintCars(cars);
    }

    private static void PrintCars(List<Car> cars)
    {
        foreach (var car in cars)
        {
            Console.WriteLine(car.ToString());
        }
    }

    private static List<Car> GetCars(List<Engine> engines)
    {
        var listOfCars= new List<Car>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = input[0];
            var engine = input[1];

            var currCar = new Car(model, engines.Where(e => e.Model == input[1]).FirstOrDefault());

            if (input.Length == 3)
            {
                int weight;
                var isDisplacement = int.TryParse(input[2], out weight);

                if (isDisplacement)
                {
                    currCar.Weight = weight;
                }
                else
                {
                    var color = input[2];
                    currCar.Color = color;
                }
            }
            else if (input.Length == 4)
            {
                var weight = int.Parse(input[2]);
                var color = input[3];
                currCar.Weight = weight;
                currCar.Color = color;
            }

            listOfCars.Add(currCar);
        }

        return listOfCars;
    }

    private static List<Engine> GetEngines()
    {
        var listOfEngines = new List<Engine>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var model = input[0];
            var power = int.Parse(input[1]);

            listOfEngines.Add(new Engine(model, power));

            if (input.Length == 3)
            {
                int displacement;
                var isDisplacement = int.TryParse(input[2], out displacement);

                if (isDisplacement)
                {
                    listOfEngines[listOfEngines.Count - 1].Displacement = displacement;
                }
                else
                {
                    var efficiency = input[2];
                    listOfEngines[listOfEngines.Count - 1].Efficiency = efficiency;
                }
            }
            else if (input.Length == 4)
            {
                var displacement = int.Parse(input[2]);
                var efficiency = input[3];
                listOfEngines[listOfEngines.Count - 1].Displacement = displacement;
                listOfEngines[listOfEngines.Count - 1].Efficiency = efficiency;
            }
        }

        return listOfEngines;
    }
}

