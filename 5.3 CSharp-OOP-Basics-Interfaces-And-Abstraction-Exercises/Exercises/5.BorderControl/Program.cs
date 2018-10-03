using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var peopleList = GetPeople();
        var fakeDigits = Console.ReadLine();

        peopleList =  peopleList.Where(p => p.Id.EndsWith(fakeDigits)).ToList();

        foreach (var people in peopleList)
        {
            Console.WriteLine(people);
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

            if (peopleInput.Length == 2)
            {
                var currRobot = new Robot(peopleInput[0], peopleInput[1]);
                peopleList.Add(currRobot);
            }
            else if(peopleInput.Length == 3)
            {
                var currCitizen = new Citizen(peopleInput[0], int.Parse(peopleInput[1]), (peopleInput[2]));
                peopleList.Add(currCitizen);
            }
        }

        return peopleList;
    }
}

