using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider : HarvetersAndProviders
{
    private double energyOutput;

    public Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    protected override int MaxValue => 10_000;

    public double EnergyOutput
    {
        get
        {
            return this.energyOutput;
        }
        protected set
        {
            if (!ValidateForNegative(value) || !ValidateForMax(value, this.MaxValue + 1))
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(this.EnergyOutput)}");
            }
            this.energyOutput = value;
        }
    }

    public override string ToString()
    {
        var type = this.GetType().Name;
        var currType = type.Substring(0, type.IndexOf("Provider"));

        var builder = new StringBuilder();
        builder.AppendLine($"{currType} Provider - {this.Id}")
            .AppendLine($"Energy Output: {this.EnergyOutput}");

        return builder.ToString().Trim();
    }
}
