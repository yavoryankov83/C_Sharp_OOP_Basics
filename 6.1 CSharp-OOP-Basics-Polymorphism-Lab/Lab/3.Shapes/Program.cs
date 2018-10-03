using System;


class Program
{
    static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(4, 5);
        Shape circle = new Circle(5);

        Console.WriteLine(string.Format($"{rectangle.CalculateArea():F2}"));
        Console.WriteLine(string.Format($"{rectangle.CalculatePerimeter():F2}"));
        Console.WriteLine(rectangle.Draw());

        Console.WriteLine(string.Format($"{circle.CalculateArea():F2}"));
        Console.WriteLine(string.Format($"{circle.CalculatePerimeter():F2}"));
        Console.WriteLine(circle.Draw());
    }
}

