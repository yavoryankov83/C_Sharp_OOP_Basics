using System;


class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());

        for (int rowSize = 0; rowSize < size; rowSize++)
        {
            PrintRow(size, rowSize);
        }
        for (int rowSize = size; rowSize >= 0; rowSize--)
        {
            PrintRow(size, rowSize);
        }
    }

    static void PrintRow(int size, int rowSize)
    {
        for (int i = 0; i < size - rowSize; i++)
        {
            Console.Write(" ");
        }
        for (int i = 0; i < rowSize; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

