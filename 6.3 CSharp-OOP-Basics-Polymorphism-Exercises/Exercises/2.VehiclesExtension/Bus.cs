using System;
using System.Collections.Generic;
using System.Text;


class Bus : Vehicle
{
    private const double INCREASE_CONSUMPTION = 1.4;

    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption, tankCapacity)
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

    public void DriveEmpty(double distance)
    {
        var enoughtFuel = distance * this.FuelConsumption;

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
        if (this.IsValidRefuel(fuel))
        {
            if (this.IsAvailableSpace(fuel))
            {
                this.FuelQuantity += fuel;
            }
            else
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
        }
        else
        {
            Console.WriteLine($"Fuel must be a positive number");
        }
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
    }
}

