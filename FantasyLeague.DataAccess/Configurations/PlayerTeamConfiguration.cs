using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class PlayerTeamConfiguration : IEntityTypeConfiguration<PlayerTeam>
{
        public void Configure(EntityTypeBuilder<PlayerTeam> builder)
        {
                throw new NotImplementedException();
        }
}
