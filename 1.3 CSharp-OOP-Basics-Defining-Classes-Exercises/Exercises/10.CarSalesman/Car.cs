using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    private string model;
    private Engine engine;
    private int? weight;
    private string color;

    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
    }


    public string Color
    {
        get { return color; }
        set { color = value; }
    }


    public int Weight
    {
        //get { return weight; }
        set { weight = value; }
    }



    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }


    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public override string ToString()
    {
        var result = $"{this.Model}:";

        result = string.Concat(result, Environment.NewLine);

        result = string.Concat(result, this.Engine.ToString());
        result = string.Concat(result, this.weight == null ? "  Weight: n/a" : $"  Weight: {this.weight}");

        result = string.Concat(result, Environment.NewLine);

        result = string.Concat(result, this.Color == null ? "  Color: n/a" : $"  Color: {this.Color}");

        result = string.Concat(result, Environment.NewLine);

        return result;
    }
}

