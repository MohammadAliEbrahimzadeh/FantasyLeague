using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
        public void Configure(EntityTypeBuilder<Role> builder)
        {
                builder
                        .HasKey(x => x.Id);

                builder
                        .HasMany(x => x.UserRoles)
                        .WithOne(x => x.Role)
                        .HasForeignKey(x => x.RoleId)
                        .IsRequired(true);
        }
}
