using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var result = new List<Department>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();

            var department = input[3];

            if (!result.Any(d => d.Name == department))
            {
                var department1 = new Department(department);
                result.Add(department1);
            }

            var dep = result.FirstOrDefault(d => d.Name == department);

            var emploee = ParseEmploee(input);
            dep.AddEmploee(emploee);
        }

        var highestSalaryDep = result.OrderByDescending(d => d.AverageSalary).First();

        Console.WriteLine($"Highest Average Salary: {highestSalaryDep.Name}");

        foreach (var item in highestSalaryDep.Emploees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{item.Name} {item.Salary:F2} {item.Email} {item.Age}");
        }
    }
    public static Employee ParseEmploee(string[] input)
    {
        var name = input[0];
        var salary = double.Parse(input[1]);
        var position = input[2];
        var email = "n/a";
        var age = -1;

        if (input.Length == 5)
        {
            var isAge = int.TryParse(input[4], out age);

            if (!isAge)
            {
                email = input[4];
                age = -1;
            }
        }

        else if (input.Length == 6)
        {
            email = input[4];
            age = int.Parse(input[5]);
        }
        var emploee = new Employee(name, salary, position, email, age);

        return emploee;
    }
}

