using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        var capacity = 20 * 3;

        var patientsByDepartment = new Dictionary<string, HashSet<string>>();
        var patientsByDoctor = new Dictionary<string, SortedSet<string>>();

        while (true)
        {
            var input = Console.ReadLine();

            if (input == "Output")
            {
                break;
            }
            else
            {
                var tokens = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var department = tokens[0];
                var doctor = tokens[1] + " " + tokens[2];
                var patient = tokens[3];

                if (!patientsByDepartment.ContainsKey(department))
                {
                    patientsByDepartment[department] = new HashSet<string>();
                }

                if (!patientsByDoctor.ContainsKey(doctor))
                {
                    patientsByDoctor[doctor] = new SortedSet<string>();
                }

                var departmentCapacity = patientsByDepartment[department].Count();

                if (departmentCapacity < capacity)
                {
                    patientsByDepartment[department].Add(patient);
                    patientsByDoctor[doctor].Add(patient);
                }
            }
        }

        SearchHospital(patientsByDepartment, patientsByDoctor);
    }

    private static void SearchHospital(Dictionary<string, HashSet<string>> patientsByDepartment, Dictionary<string, SortedSet<string>> patientsByDoctor)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }
            else
            {
                var tokens = input
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var department = tokens[0];

                switch (tokens.Count)
                {
                    case 2:
                        if (patientsByDepartment.ContainsKey(department))
                        {
                            var room = int.Parse(tokens[1]);
                            patientsByDepartment[department]
                                .Skip(3 * (room - 1))
                                .Take(3)
                                .OrderBy(p => p)
                                .ToList()
                                .ForEach(p => Console.WriteLine(p));
                        }
                        else
                        {
                            var doctor = tokens[0] + " " + tokens[1];

                            if (patientsByDoctor.ContainsKey(doctor))
                            {
                                patientsByDoctor[doctor]
                                    .ToList()
                                    .ForEach(p => Console.WriteLine(p));
                            }

                        }
                        break;
                    case 1:
                        if (patientsByDepartment.ContainsKey(department))
                        {
                            patientsByDepartment[department]
                                .ToList()
                                .ForEach(p => Console.WriteLine(p));
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

