using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface ILiving
    {
        public string Name { get; set; }

        public string Birthdate { get; set; }

        public string Age => Birthdate.Split('/')[2];
    }
}
