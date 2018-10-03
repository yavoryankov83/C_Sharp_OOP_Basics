using System;
using System.Collections.Generic;
using System.Text;


public class Truck : Vehicle
{
    private const double INCREASE_CONSUMPTION = 1.6;
    private const double DECREASE_FUEL = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption)
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
        fuel = fuel * DECREASE_FUEL;
        this.FuelQuantity += fuel;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}

