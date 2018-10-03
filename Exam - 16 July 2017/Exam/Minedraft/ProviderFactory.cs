﻿using System;
using System.Collections.Generic;
using System.Text;

public class ProviderFactory
{
    public Provider RegisterProvider(string type, string id, double energyOutput)
    {
        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);

            case "Pressure":
                return new PressureProvider(id, energyOutput);

            default:
                return null;
        }
    }
}
