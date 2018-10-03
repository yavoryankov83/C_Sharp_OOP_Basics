﻿using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            salary = value;
        }
    }


    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }


    public string LastName
    {
        get { return lastName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }


    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (Age > 30)
        {
            Salary += (Salary * percentage) / 100;
        }
        else
        {
            Salary += (Salary * (percentage / 2)) / 100;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} gets {Salary:F2} leva.";
    }
}