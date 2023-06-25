

namespace FantasyLeague.Model.Models;

public partial class League : BaseEntity
{
    public string? InvitationCode { get; set; }

    public bool IsPrivate { get; set; }
}

public partial class League
{
    public ICollection<SquadLeague>? UserLeagues { get; set; }
}
