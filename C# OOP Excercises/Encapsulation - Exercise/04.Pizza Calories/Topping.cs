using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        public Topping(string type, double grams)
        {
           Type = type;
           Grams = grams;
        }
		private string type;

		public string Type
		{
			get { return type; }
			set {
				if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese"
                    && value.ToLower() != "sauce")
				{
                    throw new Exception($"Cannot place {value} on top of your pizza.");
				}
				type = value; }
		}
		private double grams;

		public double Grams
		{
			get { return grams; }
			set {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{type} weight should be in the range [1..50].");
                }
                grams = value; }
		}
		public double Calories => CalculatingCaloriesPerGram();

        public double CalculatingCaloriesPerGram()
		{
            double modifierType = 0;
            if (Type.ToLower() == "meat")
            {
                modifierType = 1.2;
            }
            else if (Type.ToLower() == "veggies")
            {
                modifierType = 0.8;
            }
            else if (Type.ToLower() == "cheese")
            {
                modifierType = 1.1;
            }
            else if (Type.ToLower() == "sauce")
            {
                modifierType = 0.9;
            }
            return modifierType * Grams * 2;
        }
    }
}
