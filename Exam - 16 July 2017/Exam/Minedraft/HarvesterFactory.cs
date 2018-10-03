using System;
using System.Collections.Generic;
using System.Text;

public class HarvesterFactory
{
    public Harvester RegisterHarvester(string id, double oreOutput, double energyRequirement)
    {
        return new HammerHarvester(id, oreOutput, energyRequirement);
    }

    public Harvester RegisterHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
    {
        return new SonicHarvester(id, oreOutput, energyRequirement, sonicFactor);
    }

    internal Harvester RegisterHarvester(List<string> input)
    {
        var type = input[0];
        var id = input[1];
        var oreOutput = double.Parse(input[2]);
        var energyRequirement = double.Parse(input[3]);

        if (type == "Sonic")
        {
            var sonicFactor = int.Parse(input[4]);

            return this.RegisterHarvester(id, oreOutput, energyRequirement, sonicFactor);
        }
        else
        {
            return this.RegisterHarvester(id, oreOutput, energyRequirement);
        }
    }
}

