using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {

		public Person(string name, int money)
		{
			Name = name;
			Money = money;
			bagofproducts = new List<Product>();
		}

		public string name;

		public string Name
        {
			get { return name; }
			set {
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("Name cannot be empty");
                }
                name = value;
            }
		}
		private int money;

		public int Money
        {
			get { return money; }
			set {
				if (value < 0)
				{
					throw new Exception("Money cannot be negative");
				}
				 money = value; 
            }
		}
		private List<Product> bagofproducts;

		public List<Product> Bagofproducts
        {
			get { return bagofproducts; }
			set { bagofproducts = value; }
		}
		public string BuyProduct(Product product)
		{
			if (Money >= product.Cost)
			{
				 Money -= product.Cost;
				 bagofproducts.Add(product);
				 return $"{this.Name} bought {product.Name}";
			}
			else
			{
				return ($"{this.Name} can't afford {product.Name}");
            }
		}
	}
}
