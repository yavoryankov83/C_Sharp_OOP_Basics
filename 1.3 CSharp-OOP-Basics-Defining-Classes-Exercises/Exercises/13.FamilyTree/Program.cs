using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        var searchedPerson = Console.ReadLine();
        var allPeople = new List<Person>();
        CollectData(allPeople);
        PrintParentsAndChildren(allPeople, searchedPerson);
    }

    private static void PrintParentsAndChildren(List<Person> allPeople, string searchedPersonParam)
    {
        var person = allPeople.FirstOrDefault(p => (searchedPersonParam.Contains("/"))
            ? p.BirthDay == searchedPersonParam
            : p.Name == searchedPersonParam);

        var result = new StringBuilder();
        result.AppendLine($"{person.Name} {person.BirthDay}");

        result.AppendLine("Parents:");
        foreach (var parent in allPeople.Where(p => p.FindChildName(person.Name) != null))
        {
            result.AppendLine($"{parent.Name} {parent.BirthDay}");
        }

        result.AppendLine("Children:");
        foreach (var child in allPeople.FirstOrDefault(p => p.Name == person.Name).Children)
        {
            result.AppendLine($"{child.Name} {child.BirthDay}");
        }

        Console.WriteLine(result);
    }

    private static void CollectData(List<Person> allPeople)
    {
        string inputLine;
        while ((inputLine = Console.ReadLine()) != "End")
        {
            if (inputLine.Contains("-"))
            {
                var tokens = inputLine
                    .Split('-')
                    .Select(x => x.Trim())
                    .ToArray();

                var parentParam = tokens[0];
                var childParam = tokens[1];

                // Parent
                var parent = allPeople.FirstOrDefault(p => (parentParam.Contains("/"))
                    ? p.BirthDay == parentParam
                    : p.Name == parentParam);

                if (parent == null)
                {
                    parent = (parentParam.Contains("/"))
                        ? new Person { BirthDay = parentParam }
                        : new Person { Name = parentParam };

                    allPeople.Add(parent);
                }

                // Child
                var child = (childParam.Contains("/"))
                    ? new Person { BirthDay = childParam }
                    : new Person { Name = childParam };

                parent.AddChild(child);
            }
            else
            {
                var tokens = inputLine.Split(' ');

                var name = $"{tokens[0]} {tokens[1]}";
                var date = tokens[2];
                var added = false;

                for (int i = 0; i < allPeople.Count; i++)
                {
                    if (allPeople[i].Name == name)
                    {
                        allPeople[i].BirthDay = date;
                        added = true;
                    }

                    if (allPeople[i].BirthDay == date)
                    {
                        allPeople[i].Name = name;
                        added = true;
                    }

                    allPeople[i].AddChildrenInfo(name, date);
                }

                if (!added)
                {
                    allPeople.Add(new Person(name, date));
                }
            }
        }
    }
}

