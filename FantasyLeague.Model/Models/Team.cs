

namespace FantasyLeague.Model.Models;

public partial class Team : BaseEntity
{
        public string? Name { get; set; }

        public string? ShortName { get; set; }

        public string? Tla { get; set; }

        public string? Logo { get; set; }

        public int FoundedYear { get; set; }

        public string? ClubColors { get; set; }

        public int FootballDataId { get; set; }
}

public partial class Team
{
        public ICollection<PlayerTeam>? PlayerTeams { get; set; }
}
