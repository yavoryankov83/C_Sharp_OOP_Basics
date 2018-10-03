using System;
using System.Collections.Generic;
using System.Text;


public class PriceCalculator
{
    private double pricePerNight;
    private int nights;
    private SeasonMultiply season;
    private Discounts discounts;

    public PriceCalculator(string inputCommand)
    {
        var input = inputCommand.Split();
        pricePerNight = double.Parse(input[0]);
        nights = int.Parse(input[1]);
        season = Enum.Parse<SeasonMultiply>(input[2]);
        discounts = Discounts.None;
        if (input.Length > 3)
        {
            discounts = Enum.Parse<Discounts>(input[3]);
        }
    }

    public string Calculate()
    {
        var currPrice = pricePerNight * nights * (int)season;
        var discount = ((double)100 - (int)discounts) / 100;
        var totalPrice = currPrice * discount;

        return totalPrice.ToString("F2");
    }
}

