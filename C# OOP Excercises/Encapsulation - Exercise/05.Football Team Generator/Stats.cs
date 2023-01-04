namespace _5.Football_Team_Generator
{
    using System;
    public class Stats
    {
        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }
        private int endurance;

        public int Endurance
        {
            get { return endurance; }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatMessage, nameof(Endurance)));
                }
                endurance = value;
            }
        }
        private int sprint;

        public int Sprint
        {
            get { return sprint; }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatMessage, nameof(Sprint)));
                }
                sprint = value;
            }
        }
        private int dribble;

        public int Dribble
        {
            get { return dribble; }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatMessage, nameof(Dribble)));
                }
                dribble = value;
            }
        }
        private int passing;

        public int Passing
        {
            get { return passing; }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatMessage, nameof(Passing)));
                }
                passing = value;
            }
        }
        private int shooting;

        public int Shooting
        {
            get { return shooting; }
            private set
            {
                if (IsStatInvalid(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidStatMessage, nameof(Endurance)));
                }
                shooting = value;
            }
        }
        private bool IsStatInvalid(int value)
        => value < 0 || value > 100;
    }
}
