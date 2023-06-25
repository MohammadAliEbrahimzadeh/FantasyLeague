

namespace FantasyLeague.Model.Models;

public partial class UserRole : BaseEntity
{
}

public partial class UserRole
{
    public User? User { get; set; }

    public string? UserId { get; set; }

    public Role? Role { get; set; }

    public string? RoleId { get; set; }
}
