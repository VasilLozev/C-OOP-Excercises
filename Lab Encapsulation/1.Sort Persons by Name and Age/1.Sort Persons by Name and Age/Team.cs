using PersonsInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace _1.Sort_Persons_by_Name_and_Age
{
    public class Team
    {
		public Team(string name)
		{
			Name = name;
			firstTeam = new List<Person>();
			reserveTeam = new List<Person>();
		}
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private List<Person> firstTeam;

        public IReadOnlyCollection<Person> FirstTeam => firstTeam.AsReadOnly();
       
        private List<Person> reserveTeam;

        public IReadOnlyCollection<Person> ReserveTeam	=> reserveTeam.AsReadOnly();

		public void AddPlayer(Person person)
		{
			if (person.Age < 40)
			{
				firstTeam.Add(person);
			}
			else
			{
				reserveTeam.Add(person);
			}
		} 
    }
}
