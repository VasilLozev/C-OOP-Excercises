namespace MilitaryElite.Models
{
    using Interfaces;

    public abstract class Soldier : ISoldier
    {
		protected Soldier(int id, string firstName, string lastName)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
		}
		private int id;

		public int Id
		{
			get { return id; }
			private set { id = value; }
		}
		private string firstName;

		public string FirstName
        {
			get { return firstName; }
			private set { firstName = value; }
		}
		private string lastName;

		public string LastName
        {
			get { return lastName; }
			private set { lastName = value; }
		}
		public override string ToString()
		{
			return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";

        }
	}
}
