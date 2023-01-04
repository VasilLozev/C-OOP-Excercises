using _5.Football_Team_Generator;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
		public Team(string name)
		{
			Name = name;
		}
		protected int NumberOfPlayers => players.Count;

		
		private string name;

		public string Name
		{
			get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(String.Format(ExceptionMessages.NameCannotBeNullOrWhiteSpace));
                }
                name = value;
            }
        }
		protected List<Player> players = new List<Player>();
		public int Rating
		=> this.players.Count > 0 ?
			(int)Math.Round(this.players.Average(p => p.OveralRating) / this.NumberOfPlayers, 0) : 0;

        public void AddPlayer(Player player)
		{
			players.Add(player);
		}
		public void RemovePlayer(string playerName)
		{
			Player playerToRemove = this.players
				.FirstOrDefault(p => p.Name == playerName);
			if (playerToRemove == null)
			{
				throw new InvalidOperationException(string.Format(ExceptionMessages.MissingPlayerMessage,
					playerName, this.Name));
			}
			players.Remove(playerToRemove);
		}
		public override string ToString()
		{
			return $"{this.Name} - {this.Rating}";

        }
    }
}
