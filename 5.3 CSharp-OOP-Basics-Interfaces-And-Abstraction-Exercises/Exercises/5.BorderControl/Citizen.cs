﻿using System;
using System.Collections.Generic;
using System.Text;


public class Citizen :IPeople
{
    public int Age { get; private set; }

    public string Name { get; private set; }

    public string Id { get; private set; }

    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }

    public override string ToString()
    {
        return $"{this.Id}";
    }
}

