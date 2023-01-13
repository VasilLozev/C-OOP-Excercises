
namespace MilitaryElite.Models
{
    using Interfaces;
	using MilitaryElite.Models.Enums;

	public class Repair	: IRepair
    {
		public Repair(string partName, int hoursWorked)
		{
		    PartName = partName;
			HoursWorked = hoursWorked;
		}
		private string partName;

		public string PartName
        {
			get { return partName; }
			private set { partName = value; }
		}
		private int hoursWorked;

		public int HoursWorked
        {
			get { return hoursWorked; }
			private set { hoursWorked = value; }
		}
		public override string ToString()
		{
			return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
		}
	}
}