using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class SeasonConfiguraion : IEntityTypeConfiguration<Season>
{
        public void Configure(EntityTypeBuilder<Season> builder)
        {
                throw new NotImplementedException();
        }
}
