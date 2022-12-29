﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input");
                }
                name = value;
            }
        }
        private int age;
        public int Age {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input");
                }
                age = value;
            }
        }
        private string gender;
        public string Gender { 
            get { return gender; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input");
                }
                gender = value;
            } 
        }
        public virtual string ProduceSound() => "Noise";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine(ProduceSound());
            return sb.ToString();
        }
    }
}
