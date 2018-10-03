using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private string model;
    private int power;
    private int? displacement;
    private string efficiency;

    public Engine(string model, int power)
    {
        this.Model = model;
        this.Power = power;
    }


    public string Efficiency
    {
        get { return efficiency; }
        set { efficiency = value; }
    }



    public int Displacement
    {
        //get { return displacement; }
        set { displacement = value; }
    }


    public int Power
    {
        get { return power; }
        set { power = value; }
    }


    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    public override string ToString()
    {
        var result = $"  {this.Model}:";

        result = string.Concat(result, Environment.NewLine);

        result = string.Concat(result, $"    Power: {this.Power}");

        result = string.Concat(result, Environment.NewLine);

        result = string.Concat(result, this.displacement == null ? "    Displacement: n/a" : $"    Displacement: {this.displacement}");

        result = string.Concat(result, Environment.NewLine);

        result = string.Concat(result, this.Efficiency == null ? "    Efficiency: n/a" : $"    Efficiency: {this.Efficiency}");

        result = string.Concat(result, Environment.NewLine);

        return result;
    }
}

