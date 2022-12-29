using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string command = Console.ReadLine();

            while (command != "Beast!")
            {

                string[] tokens = Console.ReadLine().Split(' ',
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                string Name = tokens[0];

                int Age = int.Parse(tokens[1]);

                string Gender = string.Empty;

                if (tokens.Length > 2)
                {
                    Gender = tokens[2];
                }

                if (command == "Cat")
                {
                    Cat cat = new Cat(Name, Age, Gender);
                    result.AppendLine(cat.ToString());
                }
                else if (command == "Dog")
                {
                    Dog dog = new Dog(Name, Age, Gender);
                    result.AppendLine(dog.ToString());
                }
                else if (command == "Frog")
                {
                    Frog frog = new Frog(Name, Age, Gender);
                    result.AppendLine(frog.ToString());
                }
                else if (command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(Name, Age);
                    result.AppendLine(tomcat.ToString());
                }
                else if (command == "Kitten")
                {
                    Kitten kitten = new Kitten(Name, Age);
                    result.AppendLine(kitten.ToString());
                }
                else
                {
                    throw new ArgumentException("Invalid input!");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }
    }
}
