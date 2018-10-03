using System;
using System.Collections.Generic;
using System.Text;


public class Human
{
    private string firstName;
    private string lastName;

    protected Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    protected string LastName
    {
        get { return lastName; }
        set
        {
            Validator.IsNameFirstLetterValid(value);
            Validator.IsLastNameLengthValid(value);
            lastName = value;
        }
    }

    protected string FirstName
    {
        get { return firstName; }
        set
        {
            Validator.IsNameFirstLetterValid(value);
            Validator.IsFirstNameLengthValid(value);
            firstName = value;
        }
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine($"First Name: {this.FirstName}")
            .Append($"Last Name: {this.LastName}");

        return builder.ToString();
    }
}

