

namespace FantasyLeague.Model.Models;

public partial class Season : BaseEntity
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int CurrentMatchday { get; set; }

    public bool IsCurrentSeason { get; set; }
}
