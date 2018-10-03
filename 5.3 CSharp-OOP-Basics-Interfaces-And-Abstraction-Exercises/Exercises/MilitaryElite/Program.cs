using System;
using System.Collections.Generic;
using System.Linq;
using MilitaryElite.Contracts;

namespace MilitaryElite
{
    public class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new List<ISoldier>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var soldireType = tokens[0];
                var id = int.Parse(tokens[1]);
                var firstName = tokens[2];
                var lastName = tokens[3];
                var sallary = double.Parse(tokens[4]);

                ISoldier soldier = null;

                try
                {
                    switch (soldireType)
                    {
                        case "Private":
                            soldier = new Private(id, firstName, lastName, sallary);
                            break;
                        case "LeutenantGeneral":
                            var lueitenant = new LeutenantGeneral(id, firstName, lastName, sallary);

                            for (int i = 5; i < tokens.Length; i++)
                            {
                                var privateId = int.Parse(tokens[i]);

                                ISoldier @private = soldiers.FirstOrDefault(p => p.Id == privateId);
                                lueitenant.AddPrivate(@private);
                            }
                            soldier = lueitenant;

                            break;

                        case "Engineer":
                            var engineerCorps = tokens[5];
                            var engineer = new Engineer(id, firstName, lastName, sallary, engineerCorps);

                            for (int i = 6; i < tokens.Length; i++)
                            {
                                var partName = tokens[i];
                                var hoursWorked = int.Parse(tokens[++i]);

                                IRepair repair = new Repair(partName, hoursWorked);
                                engineer.AddRepair(repair);
                            }

                            soldier = engineer;
                            break;

                        case "Commando":
                            var commandoCorps = tokens[5];
                            var commando = new Commando(id, firstName, lastName, sallary, commandoCorps);

                            for (int i = 6; i < tokens.Length; i++)
                            {
                                var codeName = tokens[i];
                                var missionState = tokens[++i];
                                try
                                {
                                    IMission mission = new Mission(codeName, missionState);
                                    commando.AddMission(mission);
                                }
                                catch { }
                            }

                            soldier = commando;
                            break;

                        case "Spy":
                            int codeNumber = (int)sallary;
                            soldier = new Spy(id, firstName, lastName, codeNumber);
                            break;

                        default:
                            throw new ArgumentException("Invalid soldier type!");
                    }

                    soldiers.Add(soldier);
                }
                catch { }   
            }

            foreach (var s in soldiers)
            {
                Console.WriteLine(s);
            }
        }
    }
}
