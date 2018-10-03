using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var peopleList = GetPeople();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var peopleName = input;

            var currPeople = peopleList.FirstOrDefault(p => p.Name == peopleName);

            if (currPeople != null)
            {
                currPeople.BuyFood();
            }
        }
        var sum = 0;

        foreach (var people in peopleList)
        {
            sum += people.Food;
        }

        Console.WriteLine(sum);
    }

    private static List<IPeople> GetPeople()
    {
        var peopleList = new List<IPeople>();

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var firstInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (firstInput.Length == 4)
            {
                var currCitizen = new Citizen(firstInput[0], int.Parse(firstInput[1]), firstInput[2], firstInput[3]);
                peopleList.Add(currCitizen);
            }
            else if (firstInput.Length == 3)
            {
                var currRebel = new Rebel(firstInput[0], int.Parse(firstInput[1]), firstInput[2]);
                peopleList.Add(currRebel);
            }
        }

        return peopleList;
    }
}

