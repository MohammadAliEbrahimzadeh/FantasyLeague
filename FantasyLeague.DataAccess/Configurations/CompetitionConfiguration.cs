using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyLeague.DataAccess.Configurations;

public class CompetitionConfiguration : IEntityTypeConfiguration<Competition>
{
        public void Configure(EntityTypeBuilder<Competition> builder)
        {
                throw new NotImplementedException();
        }
}
