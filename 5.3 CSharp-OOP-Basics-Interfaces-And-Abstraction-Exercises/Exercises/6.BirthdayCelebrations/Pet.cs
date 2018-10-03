using System;
using System.Collections.Generic;
using System.Text;


public class Pet : IPeople
{
    public string Birthday { get; private set; }

    public string Name { get; private set; }

    public string Id { get; private set; }

    public Pet(string name, string birthday)
    {
        this.Name = name;
        this.Birthday = birthday;
    }

    public override string ToString()
    {
        return $"{this.Birthday}";
    }
}

