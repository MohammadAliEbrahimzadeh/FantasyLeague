using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
        public void Configure(EntityTypeBuilder<Player> builder)
        {
                throw new NotImplementedException();
        }
}
