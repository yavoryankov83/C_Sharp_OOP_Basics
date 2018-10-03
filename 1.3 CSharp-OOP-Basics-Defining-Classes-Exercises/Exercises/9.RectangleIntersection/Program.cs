using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        var firstLine = Console.ReadLine().Split();

        var rectangles = SetRectangles(int.Parse(firstLine[0]));
        CheckIntersections(int.Parse(firstLine[1]), rectangles);
    }

    private static void CheckIntersections(int numberOfIntersectionChecks, List<Rectangle> rectangles)
    {
        for (int i = 0; i < numberOfIntersectionChecks; i++)
        {
            var pair = Console.ReadLine().Split();

            var firstRect = rectangles.Where(r => r.Id == pair[0]).FirstOrDefault();
            var secondRect = rectangles.Where(r => r.Id == pair[1]).FirstOrDefault();

            Console.WriteLine(firstRect.IsIntersect(secondRect) ? "true" : "false");
        }
    }

    private static List<Rectangle> SetRectangles(int numberOfRectangles)
    {
        var rectangles = new List<Rectangle>(numberOfRectangles);

        for (int i = 0; i < numberOfRectangles; i++)
        {
            var input = Console.ReadLine().Split();

            rectangles.Add(new Rectangle(input[0], double.Parse(input[1]),
                double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4])));
        }
        
        return rectangles;
    }
}

