using System;
using System.Collections.Generic;
using System.Text;


public abstract class Vehicle
{
    public double FuelQuantity { get; protected set; }
    public double FuelConsumption { get; protected set; }

    public Vehicle(double fuelQuantity, double fuelConsumption)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public abstract void Drive(double distance);
    public abstract void ReFuel(double fuel);
}

