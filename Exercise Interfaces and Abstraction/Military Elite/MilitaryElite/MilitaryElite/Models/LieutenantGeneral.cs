
namespace MilitaryElite.Models
{
    using Interfaces;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly ICollection<IPrivate> privates;

        public IReadOnlyCollection<IPrivate> Privates
            => (IReadOnlyCollection<IPrivate>)this.privates;


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (IPrivate pr in Privates)
            {
                sb.AppendLine($"  {pr.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }

        public LieutenantGeneral(int id, string firstName, string lastName,
            decimal salary, ICollection<IPrivate> privates) :
            base(id, firstName, lastName, salary)
        {
            this.privates = privates;
        }
    }
}
