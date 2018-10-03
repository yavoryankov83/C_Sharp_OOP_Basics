using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction)
            : base(name, faction)
        {

        }

        public override double BaseHealth => 50;

        public override int BaseArmor => 25;

        public override double AbilityPoints => 40  ;

        public override double RestHealMultiplier => 0.5;

        public Backpack Backpack { get; private set; }

        public void Heal(Character character)
        {
            if (this.IsALive && character.IsALive)
            {
                if (character.Faction != this.Faction)
                {
                    throw new InvalidOperationException("Cannot heal enemy character!");
                }

                this.Health += character.AbilityPoints;
            }
        }
    }
}
