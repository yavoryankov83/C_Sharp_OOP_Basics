using System;
using System.Collections.Generic;
using System.Text;


public class Worker:Human
{
    private const int DAYS_PER_WEEK = 5;
    private decimal weekSalary;
    private int hoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int hoursPerDay)
        :base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerDay;
    }

    protected int HoursPerDay
    {
        get { return hoursPerDay; }
        set
        {
            Validator.IsWorkingHoursValid(value);
            hoursPerDay = value;
        }
    }

    protected decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            Validator.IsSalaryValid(value);
            weekSalary = value;
        }
    }

    private decimal CalcSalaryPerHour()
    {
        return (this.WeekSalary / DAYS_PER_WEEK) / this.HoursPerDay;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();

        builder.AppendLine(base.ToString())
            .AppendLine($"Week Salary: {this.WeekSalary:F2}")
            .AppendLine($"Hours per day: {this.HoursPerDay:F2}")
            .AppendLine($"Salary per hour: {CalcSalaryPerHour():F2}");

        return builder.ToString();
    }
}

