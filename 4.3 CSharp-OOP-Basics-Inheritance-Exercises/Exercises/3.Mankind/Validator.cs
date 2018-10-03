using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public static class Validator
{
    private const int FIRST_NAME_MIN_LENGTH = 3;
    private const int LAST_NAME_MIN_LENGTH = 2;
    private const int FACULTYNUM_MIN_LENGTH = 5;
    private const int FACULTYNUM_MAX_LENGTH = 10;
    private const decimal MIN_SALARY = 10M;
    private const int MIN_HOURS = 1;
    private const int MAX_HOURS = 12;

    public static bool IsNameFirstLetterValid(string name)
    {
        var firstLeter = name[0];
        var validFirstLetter = char.IsLetter(firstLeter) && char.IsUpper(firstLeter);
        
        if (!validFirstLetter)
        {
            throw new ArgumentException($"Expected upper case letter!Argument: {name}");
        }

        return true;
    }

    public static bool IsFirstNameLengthValid(string firstName)
    {
        var validLength = firstName.Length > FIRST_NAME_MIN_LENGTH;

        if (!validLength)
        {
            throw new ArgumentException($"Expected length at least {FIRST_NAME_MIN_LENGTH + 1} symbols! Argument: {firstName}");
        }

        return true;
    }

    public static bool IsLastNameLengthValid(string lastName)
    {
        var validLength = lastName.Length > LAST_NAME_MIN_LENGTH;

        if (!validLength)
        {
            throw new ArgumentException($"Expected length at least {LAST_NAME_MIN_LENGTH + 1} symbols! Argument: {lastName}");
        }

        return true;
    }

    public static bool IsFacultyNumberValid(string facultyNumber)
    {
        var validLength = facultyNumber.Length >= FACULTYNUM_MIN_LENGTH
            && facultyNumber.Length <= FACULTYNUM_MAX_LENGTH;

        var validContain = facultyNumber.All(Char.IsLetterOrDigit);

        if (!validLength || !validContain)
        {
            throw new ArgumentException($"Invalid faculty number!");
        }

        return true;
    }

    public static bool IsSalaryValid(decimal salary)
    {
        var minSum = salary > MIN_SALARY;

        if (!minSum)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {salary}");
        }

        return true;
    }

    public static bool IsWorkingHoursValid(int workingHours)
    {
        var validHours = workingHours >= MIN_HOURS
            && workingHours <= MAX_HOURS;

        if (!validHours)
        {
            throw new ArgumentException($"Expected value mismatch! Argument: {workingHours}");
        }

        return true;
    }
}

