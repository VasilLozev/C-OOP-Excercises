namespace BorderControl
{
    public class Citizen: ICitizenRobot, ILiving
    {
        public Citizen(string name, int age, long id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }

        public string Birthdate { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public long Id { get; set; }
    }
}
