namespace BorderControl
{
    public class Robot: ICitizenRobot
    {
        public Robot(string model, long id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public long Id { get; set; }
    }
}
