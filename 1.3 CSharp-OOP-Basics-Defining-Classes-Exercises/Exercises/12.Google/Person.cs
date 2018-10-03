using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Person
{
    private string name;
    private Company company;
    private Car car;
    private Queue<Pokemon> pokemons;
    private Queue<Parents> parents;
    private Queue<Children> childrens;

    public Person(string name)
    {
        this.Name = name;
        this.Company = company;
        this.Car = car;
        this.Pokemons = new Queue<Pokemon>();
        this.Parents = new Queue<Parents>();
        this.Childrens = new Queue<Children>();
    }

    public Queue<Children> Childrens
    {
        get { return childrens; }
        set { childrens = value; }
    }


    public Queue<Parents> Parents
    {
        get { return parents; }
        set { parents = value; }
    }


    public Queue<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }


    public Car Car
    {
        get { return car; }
        set { car = value; }
    }


    public Company Company
    {
        get { return company; }
        set { company = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void AddInCollection(Children child)
    {
        this.Childrens.Enqueue(child);
    }

    public void AddInCollection(Parents paretn)
    {
        this.Parents.Enqueue(paretn);
    }

    public void AddInCollection(Pokemon pok)
    {
        this.Pokemons.Enqueue(pok);
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(this.Name);

        builder.AppendLine("Company:");
        if (this.Company != null)
        {
            builder.AppendLine(this.Company.ToString());
        }

        builder.AppendLine("Car:");
        if (this.Car != null)
        {
            builder.AppendLine(this.Car.ToString());
        }

        builder.AppendLine("Pokemon:");
        if (this.Pokemons.Count > 0)
        {
            builder.AppendLine(string.Join(Environment.NewLine, this.Pokemons.Select(p => p.ToString())));
        }

        builder.AppendLine("Parents:");
        if (this.Parents.Count > 0)
        {
            builder.AppendLine(string.Join(Environment.NewLine, this.Parents.Select(p => p.ToString())));
        }

        builder.AppendLine("Children:");
        if (this.Childrens.Count > 0)
        {
            builder.AppendLine(string.Join(Environment.NewLine, this.Childrens.Select(p => p.ToString())));
        }

        return builder.ToString();
    }
}

