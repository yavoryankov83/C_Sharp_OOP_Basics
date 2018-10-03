using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    public string Model { get; private set; }
    public Engine Engine { get; private set; }
    public Cargo Cargo { get; private set; }
    public List<Tires> Tires{ get; private set; }

    public Car(string model, Engine engine, Cargo cargo, List<Tires> tires)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
        Tires = tires;
    }   
}

