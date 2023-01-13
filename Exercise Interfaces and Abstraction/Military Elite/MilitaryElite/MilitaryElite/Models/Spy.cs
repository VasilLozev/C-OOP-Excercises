

namespace MilitaryElite.Models
{
    using Interfaces;
    using System;

    public class Spy : Soldier, ISpy
    {
        private int codeNumber;

        public int CodeNumber
        {
            get { return codeNumber; }
            private set { codeNumber = value; }
        }

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
