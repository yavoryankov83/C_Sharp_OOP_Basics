using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction)
            :base(name, faction)
        {

        }

        public Satchel Satchel { get; private set; }

        public override double BaseHealth => 100;

        public override int BaseArmor => 50;

        public override double AbilityPoints => 40;

        public void Attack(Character character)
        {
            if (this.IsALive && character.IsALive)
            {
                if (this.Name == character.Name)
                {
                    throw new InvalidOperationException("Cannot attack self!");
                }

                if (character.Faction == this.Faction)
                {
                    throw new ArgumentException($"Friendly fire! Both characters are from {character.Faction} faction!");
                }

                this.TakeDamage(character.AbilityPoints);
            }
        }
    }
}
