using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            string[] input = Console.ReadLine().Split(";");
            try
            {
                foreach (string inputItem in input)
                {
                    string[] props = inputItem.Split('=');
                    people.Add(new Person(props[0], int.Parse(props[1])));
                }
                string[] input2 = Console.ReadLine().Split(";");
                foreach (string inputItem in input2)
                {
                    string[] props = inputItem.Split('=');
                    products.Add(new Product(props[0], int.Parse(props[1])));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); 
                Environment.Exit(1);
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] input3 = command.Split(' ');
                Console.WriteLine(people.Where(x => x.name == input3[0]).First().BuyProduct(products.Where(x=>x.Name == input3[1]).First()));
            }
            foreach (var person in people)
            {
                if (person.Bagofproducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {String.Join(", ", person.Bagofproducts.Select(x=>x.Name))}");
                }
            }
        }
    }
}
