using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var persons = GetPersonsData();

        var neededName = Console.ReadLine();

        PrintPersons(persons, neededName);
    }

    private static void PrintPersons(Queue<Person> persons, string neededName)
    {
        var finalPerson = persons.Where(p => p.Name == neededName).FirstOrDefault();

        Console.WriteLine(finalPerson.ToString());
    }

    private static Queue<Person> GetPersonsData()
    {
        var persons = new Queue<Person>();

        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            var tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var personName = tokens[0];
            var currPerson = persons.FirstOrDefault(p => p.Name == personName);

            if (currPerson == null)
            {
                currPerson = new Person(personName);
                persons.Enqueue(currPerson);
            }

            switch (tokens[1])
            {
                case "company":
                    var companyName = tokens[2];
                    var department = tokens[3];
                    var salary = double.Parse(tokens[4]);
                    currPerson.Company = new Company(companyName, department, salary);
                    break;

                case "car":
                    var carModel = tokens[2];
                    var carSpeed = int.Parse(tokens[3]);
                    currPerson.Car = new Car(carModel, carSpeed);
                    break;

                case "pokemon":
                    var pokemonName = tokens[2];
                    var pokemonType = tokens[3];
                    currPerson.AddInCollection(new Pokemon(pokemonName, pokemonType));
                    break;

                case "parents":
                    var parentName = tokens[2];
                    var parentBirthDay = tokens[3];
                    currPerson.AddInCollection(new Parents(parentName, parentBirthDay));
                    break;

                case "children":
                    var childName = tokens[2];
                    var childBirthDay = tokens[3];
                    currPerson.AddInCollection(new Children(childName, childBirthDay));
                    break;
            }
        }

        return persons;
    }
}

