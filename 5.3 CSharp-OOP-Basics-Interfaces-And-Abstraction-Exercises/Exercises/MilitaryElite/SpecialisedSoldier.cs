using MilitaryElite.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            ParseCorps(corps);
        }

        private void ParseCorps(string corps)
        {
            var validCorps = Enum.TryParse(typeof(Corps), corps, out object outCorps);

            if (!validCorps)
            {
                throw new ArgumentException("Invalid corps");
            }
            this.Corps = (Corps)outCorps;
        }

        public Corps Corps { get; private set; }
    }
}
