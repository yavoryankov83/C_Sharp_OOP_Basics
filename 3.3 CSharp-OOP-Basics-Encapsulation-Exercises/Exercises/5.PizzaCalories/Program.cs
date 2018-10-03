using System;


class Program
{
    static void Main(string[] args)
    {
        try
        {
            var pizzaName = Console.ReadLine().Split()[1];
            var pizza = new Pizza(pizzaName);

            var dough = CreateDough();
            pizza.SetDough(dough);

            string toppingInput;
            while ((toppingInput = Console.ReadLine()) != "END")
            {
                CreatePizza(toppingInput, pizza);
            }

            Console.WriteLine(pizza);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static Dough CreateDough()
    {
        var doughInput = Console.ReadLine().Split();
        var floutType = doughInput[1];
        var bakingTechnique = doughInput[2];
        var doughWeight = double.Parse(doughInput[3]);

        var dough = new Dough(floutType, bakingTechnique, doughWeight);

        return dough;
    }

    static void CreatePizza(string toppingInput, Pizza pizza)
    {
        var tokens = toppingInput.Split();

        var toppingType = tokens[1];
        var toppingWeight = double.Parse(tokens[2]);

        var topping = new Topping(toppingType, toppingWeight);
        pizza.AddTopping(topping);
    }
}

