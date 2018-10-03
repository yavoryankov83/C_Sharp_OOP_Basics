using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Backpack : Bag
    {
        public Backpack(int capacity)
            : base(capacity)
        {
        }

        public override int Capacity => 100;
    }
}
