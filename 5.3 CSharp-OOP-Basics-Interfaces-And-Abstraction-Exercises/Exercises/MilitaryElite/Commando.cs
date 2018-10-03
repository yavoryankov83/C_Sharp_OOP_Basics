using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;

        public Commando(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>)missions;

        public void AddMission(IMission mission)
        {
            missions.Add(mission);
        }

        public void CopleteMission(string missionCodeName)
        {
            IMission mission = this.Missions.FirstOrDefault(m => m.CodeName == missionCodeName);

            if (mission == null)
            {
                throw new ArgumentException("Mission not found!");
            }

            mission.Complete();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"{nameof(this.Corps)}: {this.Corps}")
                .AppendLine($"{nameof(this.Missions)}:");

            foreach (var miss in this.Missions)
            {
                builder.AppendLine($"  {miss.ToString()}");
            }

            var result = builder.ToString().TrimEnd();

            return result;
        }
    }
}
