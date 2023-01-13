namespace MilitaryElite.Models
{
    using Enums;
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;
    public class Commando : SpecialisedSoldier, ICommando
    {
        private readonly ICollection<IMission> missions;

        public void AddMission(Mission mission)
        {
            missions.Add(mission);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
              .AppendLine("Missions:");
            foreach (IMission mission in Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
        public Commando(int id, string firstName, string lastName,
            decimal salary, Corps corps, ICollection<IMission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = missions;
        }

        public IReadOnlyCollection<IMission> Missions
            => (IReadOnlyCollection<IMission>)missions;
    }
}
