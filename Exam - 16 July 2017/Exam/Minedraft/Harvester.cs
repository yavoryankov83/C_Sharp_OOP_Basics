using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : HarvetersAndProviders
{
    private double oreOutput;
    private double energyRequirement;

    public Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    protected override int MaxValue => 20_000;

    public double OreOutput
    {
        get
        {
            return this.oreOutput;
        }
        protected set
        {
            if (!ValidateForNegative(value))
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(this.OreOutput)}");
            }
            this.oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get
        {
            return this.energyRequirement;
        }
        protected set
        {
            if (!ValidateForNegative(value) || !ValidateForMax(value, this.MaxValue))
            {
                throw new ArgumentException($"Harvester is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            this.energyRequirement = value;
        }
    }

    public override string ToString()
    {
        var type = this.GetType().Name;
        var currType = type.Substring(0, type.IndexOf("Harvester"));

        var builder = new StringBuilder();
        builder.AppendLine($"{currType} Harvester - {this.Id}")
            .AppendLine($"Ore Output: {this.OreOutput}")
            .AppendLine($"Energy Requirement: {this.EnergyRequirement}");

        return builder.ToString().Trim();
    }
}
