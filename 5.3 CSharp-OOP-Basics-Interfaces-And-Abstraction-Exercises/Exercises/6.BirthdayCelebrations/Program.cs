using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var peopleList = GetPeople();
        var specificYear = Console.ReadLine();

        peopleList = peopleList.Where(p => p.Birthday.EndsWith(specificYear)).ToList();

        if (peopleList.Count == 0)
        {
            Console.WriteLine(string.Empty);
        }
        else
        {
            foreach (var people in peopleList)
            {
                Console.WriteLine(people);
            }
        }
    }

    private static List<IPeople> GetPeople()
    {
        var peopleList = new List<IPeople>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var peopleInput = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (peopleInput.Length == 3 && peopleInput[0] == "Pet")
            {
                var pet = new Pet(peopleInput[1], peopleInput[2]);
                peopleList.Add(pet);
            }
            else if (peopleInput.Length == 5)
            {
                var currCitizen = new Citizen(peopleInput[1], int.Parse(peopleInput[2]), peopleInput[3], peopleInput[4]);
                peopleList.Add(currCitizen);
            }
        }

        return peopleList;
    }
}

