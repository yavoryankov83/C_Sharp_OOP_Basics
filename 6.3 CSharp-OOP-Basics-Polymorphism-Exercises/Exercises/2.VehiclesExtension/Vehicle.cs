using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle
{
    public double FuelQuantity { get; protected set; }
    public double FuelConsumption { get; protected set; }
    public double TankCapacity { get; protected set; }

    public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
        this.TankCapacity = tankCapacity;

        if (this.FuelQuantity > this.TankCapacity)
        {
            this.FuelQuantity = 0;
        }
    }

    public abstract void Drive(double distance);
    public abstract void ReFuel(double fuel);

    public bool IsValidRefuel(double fuel)
    {
        return fuel > 0;
    }

    public bool IsAvailableSpace(double fuel)
    {
        return this.FuelQuantity + fuel <= this.TankCapacity;
    }
}