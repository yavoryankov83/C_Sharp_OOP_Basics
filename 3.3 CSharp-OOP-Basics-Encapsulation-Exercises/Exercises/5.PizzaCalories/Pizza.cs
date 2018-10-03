﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private const int MIN_LENGHT = 1;
    private const int MAX_LENGHT = 15;

    private const int MIN_TOPPINGS = 0;
    private const int MAX_TOPPINGS = 10;

    private string name;
    private Dough dough;
    private List<Topping> toppings;

    public Pizza()
    {
        this.Toppings = new List<Topping>();
    }
    public Pizza(string name)
        :this()
    {
        this.Name = name;
    }

    private double ToppingsCalories
    {
        get
        {
            if (this.Toppings.Count == 0)
            {
                return 0;
            }
            return this.Toppings.Select(t => t.Calories).Sum();
        }
    }

    private double Calories => this.Dough.Calories + this.ToppingsCalories;

    private List<Topping> Toppings
    {
        get { return toppings; }
        set { toppings = value; }
    }


    private Dough Dough
    {
        get { return dough; }
        set { dough = value; }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > MAX_LENGHT)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_LENGHT} and {MAX_LENGHT} symbols.");
            }
            name = value;
        }
    }

    public void SetDough(Dough dough)
    {
        if (this.Dough != null)
        {
            throw new InvalidOperationException("Dough already set!");
        }
        this.Dough = dough;
    }

    public void AddTopping(Topping topping)
    {
        this.Toppings.Add(topping);
        if (this.Toppings.Count > MAX_TOPPINGS)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
        }
    }

    public override string ToString()
    {
        return $"{this.name} - {this.Calories:F2} Calories.";
    }
}

