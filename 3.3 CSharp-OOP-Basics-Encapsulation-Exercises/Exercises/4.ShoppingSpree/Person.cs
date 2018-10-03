using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Products = new List<Product>();
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }


    public decimal Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            money = value;
        }
    }


    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            name = value;
        }
    }

    private void ReduceMoney(decimal amount)
    {
        Money -= amount;
    }

    public string CanBuyProduct(Product product)
    {
        if (Money >= product.Cost)
        {
            ReduceMoney(product.Cost);
            Products.Add(product);
            return $"{Name} bought {product.Name}";
        }
        else
        {
            return $"{Name} can't afford {product.Name}";
        }
    }

    public override string ToString()
    {
        return Products.Count > 0 
            ? $"{Name} - {string.Join(", ", Products)}" 
            : $"{Name} - Nothing bought";
    }
}

