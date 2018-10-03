﻿using System;
using System.Collections.Generic;
using System.Text;


public abstract class Animal
{
    public Animal(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
    }
    public string Name { get; protected set; }
    public double Weight { get; protected set; }
    public int FoodEaten { get; protected set; }

    public abstract string ProduceSound();
    public abstract void Eat(Food food);
}

