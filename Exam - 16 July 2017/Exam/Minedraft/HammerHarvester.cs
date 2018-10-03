using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    private const int MULTIPLIER_TO_OREOUTPUT = 3;
    private const int MULTIPLIER_ENERGYREQUIREMENT = 2;

    public HammerHarvester(string id, double oreOutput, double energyRequirement)
        : base(id, oreOutput, energyRequirement)
    {
        this.OreOutput = this.OreOutput * MULTIPLIER_TO_OREOUTPUT;
        this.EnergyRequirement = this.EnergyRequirement * MULTIPLIER_ENERGYREQUIREMENT;
    }
}
