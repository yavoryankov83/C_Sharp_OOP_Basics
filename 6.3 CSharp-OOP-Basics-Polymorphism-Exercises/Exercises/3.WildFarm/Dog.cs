using System;
using System.Collections.Generic;
using System.Text;


public class Dog : Mammal
{
    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (food.GetType().Name != "Meat")
        {
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }

        this.FoodEaten += food.Quantity;
        this.Weight += 0.40 * food.Quantity;
    }

    public override string ProduceSound()
    {
        return $"Woof!";
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

