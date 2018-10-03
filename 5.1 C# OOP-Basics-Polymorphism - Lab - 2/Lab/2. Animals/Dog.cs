using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Animals
{
    class Dog : Animal
    {
        public Dog(string name, string favouritedFood)
        {
            this.Name = name;
            this.FavouriteFood = favouritedFood;
        }

        public override string ExplainMyself()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood} DJAAF";
        }
    }
}
