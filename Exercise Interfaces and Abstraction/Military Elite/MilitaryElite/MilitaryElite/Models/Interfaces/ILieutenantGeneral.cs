using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models.Interfaces
{
    using System.Collections.Generic;

    public interface ILieutenantGeneral : IPrivate
    {
        IReadOnlyCollection<IPrivate> Privates { get; }
    }
}
