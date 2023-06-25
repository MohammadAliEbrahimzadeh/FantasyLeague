

namespace FantasyLeague.Model.Models;

public partial class Squad : BaseEntity
{
    public string? Name { get; set; }
}


public partial class Squad
{
    public User? User { get; set; }

    public string? UserId { get; set; }
}