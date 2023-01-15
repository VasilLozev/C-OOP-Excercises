using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, string favouriteFood)
        {
           Name = name;
           FavouriteFood = favouriteFood;
        }
        public string Name;
        public string FavouriteFood;

        public virtual string ExplainSelf()
        {
            return $"I am {Name} and my fovourite food is {FavouriteFood}";
        }
    }
}
