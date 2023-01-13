using MilitaryElite.Models.Enums;
using MilitaryElite.Models.Interfaces;

namespace MilitaryElite.Models
{
    public class Mission : IMission
    {
		public Mission(string codeName, State state)
		{
			CodeName = codeName;
			State = state;
		}
		private string codeName;

		public string CodeName
        {
			get { return codeName; }
			private set { codeName = value; }
		}
		private State state;

		public State State
        {
			get { return state; }
			private set
			{
			}	
		}
        public void CompleteMission()
		{
			State = State.Finished;
        }
		public override string ToString()
		{
            return $"Code Name: {CodeName} State: {State}";
        }
	}
}