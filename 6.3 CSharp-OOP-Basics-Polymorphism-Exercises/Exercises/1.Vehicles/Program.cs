using System;


class Program
{
    static void Main(string[] args)
    {
        var car = GetCar();
        var truck = GetTruck();

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
                        car.Drive(double.Parse(commandInput[2]));
                        break;

                    case "Truck":
                        truck.Drive(double.Parse(commandInput[2]));
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (commandInput[1])
                {
                    case "Car":
                        car.ReFuel(double.Parse(commandInput[2]));
                        break;

                    case "Truck":
                        truck.ReFuel(double.Parse(commandInput[2]));
                        break;

                    default:
                        break;
                }
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }

    private static Vehicle GetTruck()
    {
        var input = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        return new Truck(double.Parse(input[1]), double.Parse(input[2]));
    }

    private static Vehicle GetCar()
    {
        var input = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

       return new Car(double.Parse(input[1]), double.Parse(input[2]));
    }
}

