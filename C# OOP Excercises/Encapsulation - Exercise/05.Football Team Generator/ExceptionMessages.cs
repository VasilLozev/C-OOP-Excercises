using System;
using System.Collections.Generic;
using System.Text;

namespace _5.Football_Team_Generator
{
    public static class ExceptionMessages
    {
        public const string NameCannotBeNullOrWhiteSpace =
            "A name should not be empty.";
        public const string InvalidStatMessage =
            "{0} should be between 0 and 100.";
        public const string MissingPlayerMessage =
            "Player {0} is not in {1} team.";
        public const string InexistingTeamMessage =
            "Team {0} does not exist.";
    }
}
