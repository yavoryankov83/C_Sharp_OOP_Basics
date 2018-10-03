using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var coord = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var rect = ParseRect(coord);

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var point = ParsePoints(Console.ReadLine());

            var result = rect.Contains(point);
            Console.WriteLine(result);
        }
    }

    private static Point ParsePoints(string input)
    {
        var coord = input.Split().Select(int.Parse).ToArray();
        var point = new Point(coord[0], coord[1]);

        return point;
    }

    public static Rectangle ParseRect(int[] coord)
    {
        var rect = new Rectangle(coord[0], coord[1], coord[2], coord[3]);

        return rect;
    }
}

