using System;
using System.Collections.Generic;
using System.Text;


public class Owl : Bird
{
    public Owl(string name, double weight, double wingSize)
        : base(name, weight, wingSize)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += 0.25 * food.Quantity;
    }

    public override string ProduceSound()
    {
        return $"Hoot Hoot";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

