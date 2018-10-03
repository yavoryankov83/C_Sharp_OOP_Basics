using System;
using System.Collections.Generic;
using System.Text;


public class Ferrari : ICar
{
    public string Model { get; private set; }

    public string DviverName { get; private set; }

    public Ferrari(string driverName)
    {
        this.Model = "488-Spider";
        this.DviverName = driverName;
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public string PushGas()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{UseBrakes()}/{PushGas()}/{this.DviverName}";
    }
}

