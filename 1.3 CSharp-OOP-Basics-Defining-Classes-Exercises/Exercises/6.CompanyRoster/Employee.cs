using System;
using System.Collections.Generic;
using System.Text;


public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string email;
    private int age;

    public Employee(string name, double salary, string position, string email, int age)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Email = email;
        this.Age = age;
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public double Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }
}

