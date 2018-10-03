using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int DEFAULT_MULTIPLAYER = 2;

    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>()
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0,
    };

    private Dictionary<string, double> validBakingTechniques = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0,
    };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourtype, string bakingtechnique, double weight)
    {
        this.Flourtype = flourtype;
        this.Bakingtechnique = bakingtechnique;
        this.Weight = weight;
    }

    private double FlourMultiplier => validFlourTypes[this.Flourtype];

    private double BakingTechniquesMultiplier => validBakingTechniques[this.Bakingtechnique];

    public double Calories => DEFAULT_MULTIPLAYER * this.Weight * BakingTechniquesMultiplier * FlourMultiplier;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }


    public string Bakingtechnique
    {
        get { return bakingTechnique; }
        set
        {
            ValidateTypes(value, validBakingTechniques);
            bakingTechnique = value.ToLower();
        }
    }


    public string Flourtype
    {
        get { return flourType; }
        set
        {
            ValidateTypes(value, validFlourTypes);
            flourType = value.ToLower();
        }
    }

    private static void ValidateTypes(string type, Dictionary<string, double> dictionary)
    {
        if (!dictionary.Any(f => f.Key == type.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
        }
    }
}

