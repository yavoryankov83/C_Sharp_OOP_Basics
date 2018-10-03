using System;
using System.Collections.Generic;
using System.Text;


public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        this.repo = new Dictionary<string, Student>();
    }

    public void ParseCommand(string input)
    {
        var args = input.Split();

        if (args[0] == "Create")
        {
            Create(args[1], args[2], args[3]);
        }
        else if (args[0] == "Show")
        {
            var studentName = args[1];

            if (repo.ContainsKey(studentName))
            {
                Console.WriteLine(repo[studentName]);
            }
        }
    }

    private void Create(string name, string ageStr, string gradeStr)
    {
        var age = int.Parse(ageStr);
        var grade = double.Parse(gradeStr);

        if (!repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }
}

