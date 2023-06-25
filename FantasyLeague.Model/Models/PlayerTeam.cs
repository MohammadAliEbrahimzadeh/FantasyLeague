

namespace FantasyLeague.Model.Models;

public partial class PlayerTeam : BaseEntity
{

}

public partial class PlayerTeam
{
        public Team? Team { get; set; }

        public string? TeamId { get; set; }

        public Player? Player { get; set; }

        public string? PlayerId { get; set; }
}
