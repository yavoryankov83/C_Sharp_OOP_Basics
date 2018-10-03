using System;
using System.Collections.Generic;
using System.Text;

public class PressureProvider : Provider
{
    private const double INCREASE_ENERGYOUTPUT = 1.5;

    public PressureProvider(string id, double energyOutput)
        : base(id, energyOutput)
    {
        this.EnergyOutput = this.EnergyOutput * INCREASE_ENERGYOUTPUT;
    }
}
