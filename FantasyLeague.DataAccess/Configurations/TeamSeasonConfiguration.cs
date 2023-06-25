using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class TeamSeasonConfiguration : IEntityTypeConfiguration<TeamSeason>
{
        public void Configure(EntityTypeBuilder<TeamSeason> builder)
        {
                throw new NotImplementedException();
        }
}
