using System;


class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var calc = new PriceCalculator(input);
        var totalPrice = calc.Calculate();
        Console.WriteLine(totalPrice);
    }
}

