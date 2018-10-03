﻿using System;
using System.Collections.Generic;
using System.Text;


public class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Vegetable" && food.GetType().Name != "Fruit")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += 0.10 * food.Quantity;
    }

    public override string ProduceSound()
    {
        return $"Squeak";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

