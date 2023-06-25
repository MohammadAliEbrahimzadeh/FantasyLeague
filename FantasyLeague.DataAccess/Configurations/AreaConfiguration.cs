using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
        public void Configure(EntityTypeBuilder<Area> builder)
        {
                builder
                        .HasKey(x => x.Id);

                builder
                        .HasMany(x => x.Competitions)
                        .WithOne(x => x.Area)
                        .HasForeignKey(x => x.AreaId)
                        .IsRequired(true);
        }
}
