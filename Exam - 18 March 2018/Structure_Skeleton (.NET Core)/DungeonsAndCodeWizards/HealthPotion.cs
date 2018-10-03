using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class HealthPotion : Item
    {
        public HealthPotion()
            : base()
        {
        }

        public override int Weight => 5;

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health += 20;
        }
    }
}
