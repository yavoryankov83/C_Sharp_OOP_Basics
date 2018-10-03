using System;


class Program
{
    static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        Box box = null;

        try
        {
            box = new Box(length, width, height);  
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
            return;
        }

        Console.WriteLine($"Surface Area - {box.CalculateSurfaceArea():F2}");
        Console.WriteLine($"Lateral Surface Area - {box.CalculateLateralSurfaceArea():F2}");
        Console.WriteLine($"Volume - {box.CalculateVolume():F2}");
    }
}

