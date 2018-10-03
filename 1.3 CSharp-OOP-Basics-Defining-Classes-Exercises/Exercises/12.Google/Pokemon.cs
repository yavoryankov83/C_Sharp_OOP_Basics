using System;
using System.Collections.Generic;
using System.Text;


public class Pokemon
{
    private string pokemonName;
    private string pokemonType;

    public Pokemon(string pokemonName, string pokemonType)
    {
        this.PokemonName = pokemonName;
        this.PokemonType = pokemonType;
    }

    public string PokemonType
    {
        get { return pokemonType; }
        set { pokemonType = value; }
    }


    public string PokemonName
    {
        get { return pokemonName; }
        set { pokemonName = value; }
    }

    public override string ToString()
    {
        return $"{this.PokemonName} {this.pokemonType}";
    }
}

