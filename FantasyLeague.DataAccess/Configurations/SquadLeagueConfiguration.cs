using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class SquadLeagueConfiguration : IEntityTypeConfiguration<SquadLeague>
{
        public void Configure(EntityTypeBuilder<SquadLeague> builder)
        {
                throw new NotImplementedException();
        }
}
