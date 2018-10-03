using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Item
    {
        public Item()
        {

        }

        public Item(int weight)
            : base()
        {
            this.Weight = weight;
        }

        public virtual int Weight { get; private set; }

        //public bool IsAlive { get; protected set; }

        public virtual void AffectCharacter(Character character)
        {
            if (!character.IsALive)
            {
                throw new InvalidOperationException("Must be alive to perform this action!");
            }
        }
    }
}
