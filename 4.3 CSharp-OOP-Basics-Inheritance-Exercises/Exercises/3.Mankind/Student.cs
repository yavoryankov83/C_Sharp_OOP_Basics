using System;
using System.Collections.Generic;
using System.Text;


public class Student : Human
{
    private string facultyNumber;

    public Student(string fistName, string lastName, string facultyNumber)
        : base(fistName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    protected string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            Validator.IsFacultyNumberValid(value);
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine($"Faculty number: {this.FacultyNumber}");

        return builder.ToString();
    }
}

