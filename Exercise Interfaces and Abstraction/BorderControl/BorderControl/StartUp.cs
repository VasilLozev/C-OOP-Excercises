namespace BorderControl
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<ILiving> citizenPets = new List<ILiving>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                string[] input = command.Split(' ');
                if (input.First() == "Citizen")
                {
                    string name = input[1];
                    int agePerson = int.Parse(input[2]);
                    long id = long.Parse(input[3]);
                    string birthdate = input[4];
                    citizenPets.Add(new Citizen(name, agePerson, id, birthdate));
                }
                if (input.First() == "Robot")
                {
                    string model = input[1];
                    long id = long.Parse(input[2]);
                }
                if (input.First() == "Pet")
                {
                    string name = input[1];
                    string birthdate = input[2];
                    citizenPets.Add(new Pet(name, birthdate));
                }
            }
            int age = int.Parse(Console.ReadLine());
            foreach (var citizenPet in citizenPets)
            {
                if (int.Parse(citizenPet.Age) == age)
                {
                    Console.WriteLine(citizenPet.Birthdate);
                }
            }
        }
    }
}
