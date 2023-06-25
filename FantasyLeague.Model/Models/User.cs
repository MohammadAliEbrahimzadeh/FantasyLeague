

namespace FantasyLeague.Model.Models;

public partial class User : BaseEntity
{
    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? PhoneNumber { get; set; }

    public string? ActivationCode { get; set; }

}

public partial class User
{
    public Squad? Squad { get; set; }

    public ICollection<UserRole>? UserRoles { get; set; }

    public ICollection<SquadLeague>? UserLeagues { get; set; }
}