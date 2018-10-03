using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trainer
{
    private string name;
    private int numberOfBadges;
    private Stack<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.Name = name;
        this.NumberOfBadges = 0;
        this.Pokemons = new Stack<Pokemon>();
    }

    public Stack<Pokemon> Pokemons
    {
        get { return pokemons; }
        set { pokemons = value; }
    }


    public int NumberOfBadges
    {
        get { return numberOfBadges; }
        set { numberOfBadges = value; }
    }


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void ClearDeadPokemons()
    {
        if (this.pokemons.Count > 0 && this.pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
        {
            this.pokemons = new Stack<Pokemon>(this.pokemons.Where(p => p.Health > 0));
        }

    }

    public void AddABadge()
    {
        this.numberOfBadges++;
    }
}

