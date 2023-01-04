﻿using System;
using AnimalFarm.Models;

namespace AnimalFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = new Chicken(name, age);
            Console.WriteLine(
                "Chicken {0} (age {1}) can produce {2} eggs per day.",
                chicken.Name,
                chicken.Age,
                chicken.ProductPerDay);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}