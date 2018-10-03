using System;
using System.Collections.Generic;
using System.Text;


public class Tiger : Feline
{
    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += 1.00 * food.Quantity;
    }

    public override string ProduceSound()
    {
        return $"ROAR!!!";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

