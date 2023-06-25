

namespace FantasyLeague.Model.Models;

public partial class SquadLeague : BaseEntity
{

}


public partial class SquadLeague
{
    public Squad? Squad { get; set; }

    public string? SquadId { get; set; }

    public League? League { get; set; }

    public string? LeagueId { get; set; }
}
