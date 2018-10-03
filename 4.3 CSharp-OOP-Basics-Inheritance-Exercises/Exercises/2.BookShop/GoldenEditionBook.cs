using System;
using System.Collections.Generic;
using System.Text;


public class GoldenEditionBook : Book
{
    private const decimal PERCENTS = 0.3M;

    public GoldenEditionBook(string author, string title, decimal price)
        :base(author, title, price)
    {
       
    }

    protected override decimal Price
    {
        get
        {
            return base.Price;
        }
        set
        {
            base.Price = value + (value * PERCENTS);
        }
    }
}

