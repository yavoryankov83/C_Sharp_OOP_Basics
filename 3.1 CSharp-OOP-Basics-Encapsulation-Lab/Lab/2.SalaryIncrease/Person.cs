using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }


    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
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
        return $"{FirstName} {LastName} receives {Salary:F2} leva.";
    }
}
