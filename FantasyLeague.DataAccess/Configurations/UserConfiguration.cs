using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FantasyLeague.DataAccess.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
        public void Configure(EntityTypeBuilder<User> builder)
        {
                builder
                        .HasKey(x => x.Id);

                builder
                        .HasMany(x=>x.UserRoles)
                        .WithOne(x=>x.User)
                        .HasForeignKey(x=>x.Id)
                        .IsRequired(true);

                builder
                        .Property(x=>x.Username)
                        .HasMaxLength(28);

                builder
                        .Property(x => x.PhoneNumber)
                        .HasMaxLength(11);
        }
}
