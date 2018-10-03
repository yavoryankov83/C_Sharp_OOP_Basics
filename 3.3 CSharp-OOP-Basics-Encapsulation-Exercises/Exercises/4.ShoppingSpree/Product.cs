﻿using System;

public class Product
{
    private string name;
    private decimal cost;

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }

    public decimal Cost
    {
        get { return cost; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            cost = value;
        }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    public override string ToString()
    {
        return Name;
    }
}