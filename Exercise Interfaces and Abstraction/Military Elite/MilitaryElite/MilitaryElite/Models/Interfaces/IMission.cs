namespace MilitaryElite.Models.Interfaces
{
    using MilitaryElite.Models.Enums;
    public interface IMission
    {
        public string CodeName { get; }
        State State { get; }

        void CompleteMission();
    }
}