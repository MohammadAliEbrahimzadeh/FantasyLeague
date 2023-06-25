

namespace FantasyLeague.Model.Models;

public partial class Area : BaseEntity
{
        public string? Name { get; set; }

        public string? Code { get; set; }

        public string? Logo { get; set; }
}


public partial class Area
{
    public ICollection<Competition>? Competitions { get; set; }
}
