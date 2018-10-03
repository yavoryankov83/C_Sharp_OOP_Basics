using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Satchel : Bag
    {
        public Satchel(int capacity)
            : base(capacity)
        {
        }

        public override int Capacity => 20;
    }
}
