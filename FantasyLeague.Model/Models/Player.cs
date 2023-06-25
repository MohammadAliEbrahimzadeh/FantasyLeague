

namespace FantasyLeague.Model.Models;

public partial class Player : BaseEntity
{
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? CountryOfBirth { get; set; }

        public string? Nationality { get; set; }

        public string? Position { get; set; }

        public double Value { get; set; }

        public DateTime BirthDate { get; set; }
}


public partial class Player
{
        public ICollection<PlayerTeam>? PlayerTeams { get; set; }
}
