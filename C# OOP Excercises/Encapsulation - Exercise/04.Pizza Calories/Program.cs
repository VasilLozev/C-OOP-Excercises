using System;
using PizzaCalories;
namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            Dough dough = null;
            Topping topping = null;
            string pizzaName = "";
            while (true)
            {
                try
                {
                    string command = Console.ReadLine();
                    if (command == "END")
                    {
                        break;
                    }
                    string[] input = command.Split(' ');
                    if (input[0] == "Pizza")
                    {
                        pizzaName = input[1];
                    }
                    if (input[0] == "Dough")
                    {
                        dough = new Dough(input[1], input[2], double.Parse(input[3]));
                    }
                    if (pizzaName != null && dough != null)
                    {
                        if (pizza == null)
                        {
                            pizza = new Pizza(pizzaName, dough);
                        }
                    }
                    if (input[0] == "Topping")
                    {
                        topping = new Topping(input[1], double.Parse(input[2]));
                        pizza.AddTopping(topping);
                    }
                    if (pizza != null)
                    {
                        if (pizza.NumberOfToppings > 10)
                        {
                            throw new Exception("Number of toppings should be in range [0..10].");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(1);
                }
            }
            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }
    }
}
