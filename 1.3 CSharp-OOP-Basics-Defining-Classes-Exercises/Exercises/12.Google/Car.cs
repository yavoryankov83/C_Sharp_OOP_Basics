using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string carModel;
    private double carSpeed;

    public Car(string carModel, double carSpeed)
    {
        this.CarModel = carModel;
        this.CarSpeed = carSpeed;
    }

    public double CarSpeed
    {
        get { return carSpeed; }
        set { carSpeed = value; }
    }


    public string CarModel
    {
        get { return carModel; }
        set { carModel = value; }
    }

    public override string ToString()
    {
        return $"{this.CarModel} {this.CarSpeed}";
    }
}

