using System;
using System.Collections.Generic;
using System.Linq;


public class DefineaClassPerson
{
    static void Main(string[] args)
    {
        //2 task
        //var pers = new Person("Gosho", 16);

        //var family = new Family();

        //3 task
        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    var input = Console.ReadLine().Split();
        //    var name = input[0];
        //    var age = int.Parse(input[1]);

        //    family.AddMember(new Person(name, age));
        //}

        //var oldest = family.GetOldestMember();

        //Console.WriteLine($"{oldest.Name} {oldest.Age}");

        //4 task
        var person = new List<Person>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var name = input[0];
            var age = int.Parse(input[1]);

            person.Add(new Person(name, age));
        }

        foreach (var p in person.Where(p => p.Age > 30).OrderBy(p => p.Name))
        {
            Console.WriteLine($"{p.Name} - {p.Age}");
        }
    }
}

