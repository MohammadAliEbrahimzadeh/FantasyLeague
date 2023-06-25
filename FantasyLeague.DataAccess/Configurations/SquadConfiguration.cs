using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class SquadConfiguration : IEntityTypeConfiguration<Squad>
{
        public void Configure(EntityTypeBuilder<Squad> builder)
        {
                builder
                        .HasKey(x => x.Id);

                builder
                        .HasOne(x => x.User)
                        .WithOne(x => x.Squad)
                        .HasForeignKey<Squad>(x => x.UserId)
                        .IsRequired(true);
        }
}
