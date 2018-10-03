using System;
using System.Collections.Generic;
using System.Text;


public class Cat : Feline
{
    public Cat(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat" && food.GetType().Name != "Vegetable")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += 0.30 * food.Quantity;
    }

    public override string ProduceSound()
    {
        return $"Meow";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

