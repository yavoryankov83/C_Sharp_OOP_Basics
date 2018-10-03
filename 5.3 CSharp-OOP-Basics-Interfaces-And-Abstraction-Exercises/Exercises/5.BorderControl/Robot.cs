using System;
using System.Collections.Generic;
using System.Text;


public class Robot : IPeople
{
    public string Name { get; private set; }

    public string Id { get; private set; }

    public Robot(string name, string id)
    {
        this.Name = name;
        this.Id = id;
    }

    public override string ToString()
    {
        return $"{this.Id}";
    }
}

