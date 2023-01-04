
namespace FootballTeamGenerator
{
	using _5.Football_Team_Generator;
	using System;
    public class Player
	{
		public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
		{
			Name = name;

			this.Stats = new Stats(endurance, sprint, dribble, passing, shooting);
        }
        private string name;

		public string Name
		{
			get { return name; }
			private set {
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException(ExceptionMessages.NameCannotBeNullOrWhiteSpace);
				}
				name = value; }
		}

		public Stats Stats { get; private set; }
		
		public double OveralRating
			=> (Stats.Endurance + Stats.Sprint + Stats.Dribble + Stats.Passing + Stats.Shooting) / 5.0;

    }
}
