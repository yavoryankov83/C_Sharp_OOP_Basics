using System;


class Program
{
    static void Main(string[] args)
    {
        var studentSystem = new StudentSystem();

        string input;
        while ((input = Console.ReadLine()) != "Exit")
        {
            studentSystem.ParseCommand(input);
        }
    }
}

