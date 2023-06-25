using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace FantasyLeague.DataAccess.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
                throw new NotImplementedException();
        }
}
