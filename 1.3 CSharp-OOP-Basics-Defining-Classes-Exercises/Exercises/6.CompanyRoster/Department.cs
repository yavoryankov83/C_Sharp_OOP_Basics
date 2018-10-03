using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department
{
    private List<Employee> emploees;
    private string name;

    public Department(string name)
    {
        this.Name = name;
        this.Emploees = new List<Employee>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Employee> Emploees
    {
        get { return emploees; }
        private set { this.emploees = value; }
    }

    public double AverageSalary
    {
        get
        {
            return this.Emploees.Select(e => e.Salary).Average();
        }
    }

    public void AddEmploee(Employee emploee)
    {
        this.Emploees.Add(emploee);
    }
}
