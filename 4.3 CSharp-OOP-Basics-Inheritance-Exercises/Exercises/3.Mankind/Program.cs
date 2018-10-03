using System;


class Program
{
    static void Main(string[] args)
    {
        var studentInput = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var workerInput = Console.ReadLine()
           .Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var studentFirstName = studentInput[0];
        var studentLastName = studentInput[1];
        var studentFacultyNumber = studentInput[2];

        var workerFirstName = workerInput[0];
        var workerLastName = workerInput[1];
        var workerWeekSalary = decimal.Parse(workerInput[2]);
        var workerHoursPerDay = int.Parse(workerInput[3]);

        try
        {
            var currStudent = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            var currWorker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerHoursPerDay);

            Console.WriteLine(currStudent);
            Console.WriteLine(currWorker);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

