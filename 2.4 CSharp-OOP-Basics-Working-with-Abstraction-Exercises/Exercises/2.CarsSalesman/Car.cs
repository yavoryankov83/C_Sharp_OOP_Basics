using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    public string Model { get; private set; }
    public Engine Engine { get; private set; }
    public int? Weight { get; set; }
    public string Color { get; set; }

    public Car(string model, Engine engine)
    {
        Model = model;
        Engine = engine;
    }

    public override string ToString()
    {
        var add = "n/a";

        var builder = new StringBuilder();

        builder.AppendLine($"{Model}:");
        builder.AppendLine($"  {Engine.Model}:");
        builder.AppendLine($"    Power: {Engine.Power}");
        builder.AppendLine(Engine.Displacement != null 
            ? $"    Displacement: {Engine.Displacement}" 
            : $"    Displacement: {add}");
        builder.AppendLine(Engine.Efficiency != null 
            ? $"    Efficiency: {Engine.Efficiency}"
            : $"    Efficiency: {add}");
        builder.AppendLine(Weight != null 
            ? $"  Weight: {Weight}"
            : $"  Weight: {add}");
        builder.AppendLine(Color != null 
            ? $"  Color: {Color}"
            : $"  Color: {add}");

        return builder.ToString();
    }
}

