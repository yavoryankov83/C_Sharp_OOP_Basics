using System;
using System.Collections.Generic;
using System.Text;


public class Rebel : IBuyer, IPeople
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public string Group { get; private set; }

    public Rebel(string name, int age, string group)
    {
        this.Name = name;
        this.Age = age;
        this.Group = group;
        this.Food = 0;
    }

    public int Food { get; private set; }

    public string Id { get; private set; }

    public string Birthday { get; private set; }

    public void BuyFood()
    {
        this.Food += 5;
    }
}

