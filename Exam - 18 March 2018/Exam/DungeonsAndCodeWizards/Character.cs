using System;

namespace DungeonsAndCodeWizards
{
    public abstract class Character
    {
        public Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsALive = true;
            this.RestHealMultiplier = 0.2;
        }

        public Character(string name, Faction faction)
            :base()
        {

        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }

        private double health;

        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value < 0 || value > this.BaseHealth)
                {
                    throw new ArgumentException();
                }

                this.health = value;
            }
        }

        private double armor;

        public double Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                if (value < 0 || value > this.BaseArmor)
                {
                    throw new ArgumentException();
                }

                this.armor = value;
            }
        }

        public virtual double BaseHealth  { get; private set; }

        public virtual int BaseArmor  { get; private set; }

        public virtual double AbilityPoints  { get; private set; }

        public Bag Bag { get; private set; }

        public Faction Faction  { get; private set; }

        public bool IsALive { get; set; }

        public virtual double RestHealMultiplier  { get; protected set; }

        public void TakeDamage(double hitPoints)
        {
            if (IsALive)
            {
                if (this.Armor > hitPoints)
                {
                    this.Armor -= hitPoints;

                }
                else
                {
                    var restPoints = hitPoints - this.Armor;

                    hitPoints += restPoints;
                    if (this.Health <= 0)
                    {
                        this.IsALive = false;
                    }
                }
            }
        }

        protected void Rest()
        {
            if (IsALive)
            {
                this.Health += this.BaseHealth * this.RestHealMultiplier;
            }
        }

        protected void UseItem(Item item)
        {
            if (IsALive)
            {
                item.AffectCharacter(this);
            }
        }

        protected void UseItemOn(Item item, Character character)
        {
            if (this.IsALive && character.IsALive)
            {
                item.AffectCharacter(character);
            }
        }

        protected void GiveCharacterItem(Item item, Character character)
        {
            if (this.IsALive && character.IsALive)
            {
                character.ReceiveItem(item);
            }
        }

        protected void ReceiveItem(Item item)
        {
            if (this.IsALive)
            {
                this.Bag.AddItem(item);
            }
        }
    }
}