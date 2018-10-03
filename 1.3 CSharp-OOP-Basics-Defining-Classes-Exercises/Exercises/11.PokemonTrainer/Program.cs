using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var trainers = GetTrainers();
        MoveElement(trainers);
        PrintTrainers(trainers);
    }

    private static void PrintTrainers(Queue<Trainer> trainers)
    {
        foreach (var train in trainers.OrderByDescending(t => t.NumberOfBadges))
        {
            Console.WriteLine($"{train.Name} {train.NumberOfBadges} {train.Pokemons.Count}");
        }
    }

    private static void MoveElement(Queue<Trainer> trainers)
    {
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Where(p => p.Element == input).FirstOrDefault() == null)
                {
                    foreach (var pok in trainer.Pokemons)
                    {
                        pok.ReduceHealth();
                    }

                    trainer.ClearDeadPokemons();
                }
                else
                {
                    trainer.AddABadge();
                }
            }
        }
    }

    private static Queue<Trainer> GetTrainers()
    {
        var trainersList = new Queue<Trainer>();

        string input;

        while ((input = Console.ReadLine()) != "Tournament")
        {
            var inputLines = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var trainName = inputLines[0];
            var pokName = inputLines[1];
            var pokElement = inputLines[2];
            var pokHealth = int.Parse(inputLines[3]);

            var currTrainer = trainersList.Where(t => t.Name == trainName).FirstOrDefault();
            var currPokemon = new Pokemon(pokName, pokElement, pokHealth);

            if (currTrainer == null)
            {
                currTrainer = new Trainer(trainName);
                currTrainer.Pokemons.Push(currPokemon);
                trainersList.Enqueue(currTrainer);
            }
            else
            {
                currTrainer.Pokemons.Push(currPokemon);
            }
        }

        return trainersList;
    }
}

