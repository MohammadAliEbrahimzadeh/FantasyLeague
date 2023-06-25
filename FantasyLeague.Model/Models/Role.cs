

namespace FantasyLeague.Model.Models;

public partial class Role : BaseEntity
{
    public string? RoleName { get; set; }
}

public partial class Role
{
    public ICollection<UserRole>? UserRoles { get; set; }
}
