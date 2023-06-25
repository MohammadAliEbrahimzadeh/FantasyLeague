using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class TeamConfiguration : IEntityTypeConfiguration<Team>
{
        public void Configure(EntityTypeBuilder<Team> builder)
        {
                throw new NotImplementedException();
        }
}
