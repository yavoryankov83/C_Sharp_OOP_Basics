using System;
using System.Collections.Generic;
using System.Text;

public abstract class HarvetersAndProviders
{
    protected HarvetersAndProviders(string id)
    {
        this.Id = id;
    }

    public string Id { get; protected set; }

    protected virtual int MaxValue => this.MaxValue;

    protected static bool ValidateForNegative(double value)
    {
        return value >= 0;
    }

    protected static bool ValidateForMax(double value, int max)
    {
        return value <= max;
    }
}
