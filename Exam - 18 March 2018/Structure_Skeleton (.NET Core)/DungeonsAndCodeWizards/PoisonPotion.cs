﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class PoisonPotion : Item
    {
        public PoisonPotion()
            : base()
        {
        }

        public override int Weight => 5;

        public override void AffectCharacter(Character character)
        {
            base.AffectCharacter(character);

            character.Health -= 20;

            if (character.Health <= 0)
            {
                character.IsALive = false;
            }
        }
    }
}
