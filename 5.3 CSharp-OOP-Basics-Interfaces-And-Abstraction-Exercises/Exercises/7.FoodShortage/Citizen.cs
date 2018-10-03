using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IPeople, IBuyer
{
    public int Age { get; private set; }
    public string Birthday { get; private set; }

    public string Name { get; private set; }

    public string Id { get; private set; }

    public int Food { get; private set; }

    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public Citizen(string name, int age, string id, string birthday)
        : this(name, age, id)
    {
        this.Birthday = birthday;
        this.Food = 0;
    }

    public override string ToString()
    {
        return $"{this.Birthday}";
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

