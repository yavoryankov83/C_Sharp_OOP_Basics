using System;
using System.Collections.Generic;
using System.Text;


public class Car : Vehicle
{
    private const double INCREASE_CONSUMPTION = 0.9;

    public Car(double fuelQuantity, double fuelConsumption)
        : base(fuelQuantity, fuelConsumption)
    {
    }

    public override void Drive(double distance)
    {
        var enoughtFuel = distance * (this.FuelConsumption + INCREASE_CONSUMPTION);

        if (enoughtFuel > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.FuelQuantity -= enoughtFuel;   

            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

    public override void ReFuel(double fuel)
    {
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}

