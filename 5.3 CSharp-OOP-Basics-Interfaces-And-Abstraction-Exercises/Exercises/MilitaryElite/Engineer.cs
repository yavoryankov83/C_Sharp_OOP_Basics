using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;

        public Engineer(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>) repairs;

        public void AddRepair(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"{nameof(this.Corps)}: {this.Corps.ToString()}")
                .AppendLine($"{nameof(this.Repairs)}:");

            foreach (var rep in this.Repairs)
            {
                builder.AppendLine($"  {rep.ToString()}");
            }

            var result = builder.ToString().TrimEnd();

            return result;
        }
    }
}
