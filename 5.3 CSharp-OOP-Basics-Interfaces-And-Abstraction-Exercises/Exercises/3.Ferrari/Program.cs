using System;


class Program
{
    static void Main(string[] args)
    {
        var inputDriverName = Console.ReadLine();

        var ferrari = new Ferrari(inputDriverName);

        Console.WriteLine(ferrari);
    }
}

