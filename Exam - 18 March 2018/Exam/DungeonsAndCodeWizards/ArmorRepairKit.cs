using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class ArmorRepairKit : Item
    {
        private const int ARMOR_VALUE = 100;

        public ArmorRepairKit()
            : base()
        {

        }

        public override int Weight => 10;

        public int ArmorValue { get; private set; }

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            this.ArmorValue = ARMOR_VALUE;
        }
    }
}
