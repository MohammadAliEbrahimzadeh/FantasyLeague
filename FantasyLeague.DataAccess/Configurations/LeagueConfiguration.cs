using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class LeagueConfiguration : IEntityTypeConfiguration<League>
{
        public void Configure(EntityTypeBuilder<League> builder)
        {
                throw new NotImplementedException();
        }
}
