using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public abstract class Bag
    {
        public Bag()
        {

        }

        public Bag(int capacity)
            : base()
        {
            this.Capacity = capacity;
            this.Items = new List<Item>();
        }

        public virtual int Capacity { get; private set; }

        public virtual List<Item> Items { get; }

        public virtual int Load => this.Items.Sum(i => i.Weight);

        public virtual void AddItem(Item item)
        {
            if (this.Load + item.Weight > this.Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            Items.Add(item);
        }
        public virtual Item GetItem(string name)
        {
            if (Items.Count == 0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            Item item = Items.First(i => i.GetType().Name == name);

            if (item == null)
            {
                throw new InvalidOperationException("No item with name {name} in bag!   ");

            }

            Items.Remove(item);

            return item;
        }
    }
}
