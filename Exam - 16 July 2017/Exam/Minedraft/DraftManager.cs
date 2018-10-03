using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DraftManager
{
    public string mode;
    private double producedEnergy;
    private double allProducedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;


    public DraftManager()
    {
        this.mode = "Full";
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            harvesters.Add(this.harvesterFactory.RegisterHarvester(arguments));
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

        var type = arguments[0];
        var id = arguments[1];

        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        var type = arguments[0];
        var id = arguments[1];
        var energy = double.Parse(arguments[2]);

        try
        {
            providers.Add(this.providerFactory.RegisterProvider(type, id, energy));
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }

        return $"Successfully registered {type} Provider - {id}";
    }

    public string Day()
    {
        var outputEnergy = this.providers.Select(p => p.EnergyOutput).Sum();
        var neededEnergy = this.harvesters.Select(h => h.EnergyRequirement).Sum();
        var producedOre = this.harvesters.Select(h => h.OreOutput).Sum();

        this.producedEnergy += outputEnergy;

        if (this.mode == "Half")
        {
            neededEnergy *= 0.6;
            producedOre *= 0.5;
        }

        var builder = new StringBuilder();
        builder.AppendLine($"A day has passed.")
            .AppendLine($"Energy Provided: {outputEnergy}");

        if (this.mode == "Energy" || neededEnergy > this.producedEnergy)
        {
            producedOre = 0;
            builder.AppendLine($"Plumbus Ore Mined: {producedOre}");

            return builder.ToString().Trim();
        }

        this.producedEnergy -= neededEnergy;
        this.allProducedOre += producedOre;

        builder.AppendLine($"Plumbus Ore Mined: {producedOre}");

        return builder.ToString().Trim();
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments.First();

        return $"Successfully changed working mode to {this.mode} Mode";

    }

    public string Check(List<string> arguments)
    {
        var builder = new StringBuilder();

        var currId = arguments[0];

        var currProvider = this.providers.FirstOrDefault(p => p.Id == currId);
        var currHarvester = this.harvesters.FirstOrDefault(h => h.Id == currId);

        if (currProvider == null && currHarvester == null)
        {
            builder.AppendLine($"No element found with id - {currId}");
        }

        else if (currProvider == null && currHarvester != null)
        {
            builder.AppendLine($"{currHarvester.ToString()}");
        }

        else if (currProvider != null && currHarvester == null)
        {
            builder.AppendLine($"{currProvider.ToString()}");
        }

        else
        {
            builder.AppendLine($"{currProvider.ToString()}")
                .AppendLine($"{currHarvester.ToString()}");
        }

        return builder.ToString().Trim();
    }

    public string ShutDown()
    {
        var builder = new StringBuilder();
        builder.AppendLine($"System Shutdown")
            .AppendLine($"Total Energy Stored: {this.producedEnergy}")
            .AppendLine($"Total Mined Plumbus Ore: {this.allProducedOre}");

        return builder.ToString().Trim();
    }

}

