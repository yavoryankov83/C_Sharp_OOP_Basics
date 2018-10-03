using System;
using System.Collections.Generic;
using System.Text;


public class Company
{
    private string companyName;
    private string department;
    private double salary;

    public Company(string companyName, string department, double salary)
    {
        this.companyName = companyName;
        this.Department = department;
        this.Salary = salary;
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }


    public string Department
    {
        get { return department; }
        set { department = value; }
    }


    public string CompanyName
    {
        get { return companyName; }
        set { companyName = value; }
    }

    public override string ToString()
    {
        return $"{this.CompanyName} {this.Department} {this.Salary:F2}";
    }
}

