using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceToGO;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.DistanceToGO = 0.0;
    }

    public double DistanceToGO
    {
        get { return distanceToGO; }
        set { distanceToGO = value; }
    }


    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }


    public double FuelAmount
    {
        get { return fuelAmount; }
        set { fuelAmount = value; }
    }


    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public void Drive(double kilometers)
    {
        var neededFuel = this.fuelConsumption * kilometers;

        if (neededFuel > this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.fuelAmount -= neededFuel;
            this.distanceToGO += kilometers;
        }
    }
}

