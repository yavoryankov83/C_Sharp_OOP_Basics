using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;

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

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}

