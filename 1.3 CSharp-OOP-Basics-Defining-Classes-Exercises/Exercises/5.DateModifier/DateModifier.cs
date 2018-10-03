using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class DateModifier
{
    public static void DateDiff(string data1, string data2)
    {
        var firstDate = data1
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var secondDate = data2
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var dateOne = new DateTime(firstDate[0], firstDate[1], firstDate[2]);
        var dateTwo = new DateTime(secondDate[0], secondDate[1], secondDate[2]);

        TimeSpan diff = dateOne.Subtract(dateTwo);

        Console.WriteLine(Math.Abs(diff.TotalDays));
    }
}

