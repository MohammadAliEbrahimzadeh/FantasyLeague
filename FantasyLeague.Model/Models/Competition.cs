

using FantasyLeague.Common.Eunms;

namespace FantasyLeague.Model.Models;

public partial class Competition : BaseEntity
{
        public string? Name { get; set; }

        public string? Code { get; set; }

        public string? Logo { get; set; }

        public CompetitionType CompetitionType { get; set; }
}

public partial class Competition
{
    public Area? Area { get; set; }

    public string? AreaId { get; set; }

    public ICollection<Season>? Seasons { get; set; }
}
