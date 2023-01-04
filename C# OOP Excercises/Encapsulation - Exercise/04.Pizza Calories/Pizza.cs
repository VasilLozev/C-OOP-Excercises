using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PizzaCalories
{
	public class Pizza
	{
		public Pizza(string name, Dough dough)
		{
			Name = name;
			Dough = dough;
            toppings = new List<Topping>();
        }
		private string name;

		public string Name
		{
			get { return name; }
			set {
				if (string.IsNullOrEmpty(value) || value.Length > 15)
				{
					throw new Exception("Pizza name should be between 1 and 15 symbols.");
				}
				name = value; }
		}
		private Dough dough;

		public Dough Dough
		{
			get { return dough; }
			set { dough = value; }
		}

		public int NumberOfToppings => toppings.Count;

		private List<Topping> toppings;
		public List<Topping> Toppings
		{
			get { return toppings; }
			set {
				
				toppings = value;
			}
        }

		public double TotalCalories => toppings.Sum(x => x.CalculatingCaloriesPerGram()) + dough.Calories;
		
		public void AddTopping(Topping topping)
		{
			toppings.Add(topping);
		}
	}
}
