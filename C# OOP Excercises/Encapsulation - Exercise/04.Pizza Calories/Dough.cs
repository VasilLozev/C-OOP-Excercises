using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PizzaCalories
{
	public class Dough
	{
        public Dough(string type, string bakingTechnique, double grams)
        {
            FlourType = type;
            BakingTechnique = bakingTechnique;
            Grams = grams;
        }
        private string flourType;

		public string FlourType
		{
			get { return flourType; }
			set
			{
				if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
				{
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
			}
		}
		private string bakingTechnique;

		public string BakingTechnique
		{
			get { return bakingTechnique; }
			set
			{
				if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
				{
					throw new Exception("Invalid type of dough.");
				}
				bakingTechnique = value;
			}
		}
		private double grams;
		public double Grams
		{
			get { return grams; }
			set {
				if (value < 1 || value > 200)
				{
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                grams = value; }
		}

		public double Calories => CalculatingCaloriesPerGram(); 
		

		public double CalculatingCaloriesPerGram()
		{
			double modifierNameDough = 0;
			if (flourType.ToLower() == "white")
			{
				modifierNameDough = 1.5;
			}
			else if (flourType.ToLower() == "wholegrain")
			{
				modifierNameDough = 1.0;

			}
			double modifierBakingTechnique = 0;
			if (bakingTechnique.ToLower() == "crispy")
			{
                modifierBakingTechnique = 0.9;
			}
			else if (bakingTechnique.ToLower() == "chewy")
			{
                modifierBakingTechnique = 1.1;
			}
			else if (bakingTechnique.ToLower() == "homemade")
			{
                modifierBakingTechnique = 1.0;
			}
			return Grams * 2 * modifierNameDough * modifierBakingTechnique;
		}
	}
}
