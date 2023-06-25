using FantasyLeague.DataAccess.Configurations;
using FantasyLeague.Model.Models;
using Microsoft.EntityFrameworkCore;



namespace FantasyLeague.DataAccess.Context;

public class FantasyLeagueDBContext : DbContext
{
        public FantasyLeagueDBContext(DbContextOptions<FantasyLeagueDBContext> dbContext) : base(dbContext)
        { }


        public DbSet<Area> Areas { get; set; }

        public DbSet<Competition> Competitions { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<PlayerTeam> PlayerTeams { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Season> Seasons { get; set; }

        public DbSet<TeamSeason> TeamSeasons { get; set; }

        public DbSet<Squad> Squads { get; set; }

        public DbSet<SquadLeague> SquadLeagues { get; set; }

        public DbSet<League> Leagues { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.ApplyConfiguration(new AreaConfiguration());

                modelBuilder.ApplyConfiguration(new PlayerConfiguration());

                modelBuilder.ApplyConfiguration(new CompetitionConfiguration());

                modelBuilder.ApplyConfiguration(new PlayerTeamConfiguration());

                modelBuilder.ApplyConfiguration(new SeasonConfiguraion());

                modelBuilder.ApplyConfiguration(new TeamConfiguration());

                modelBuilder.ApplyConfiguration(new LeagueConfiguration());

                modelBuilder.ApplyConfiguration(new SquadLeagueConfiguration());

                modelBuilder.ApplyConfiguration(new SquadConfiguration());

                modelBuilder.ApplyConfiguration(new TeamSeasonConfiguration());

                modelBuilder.ApplyConfiguration(new UserRoleConfiguration());

                modelBuilder.ApplyConfiguration(new UserConfiguration());

                modelBuilder.ApplyConfiguration(new RoleConfiguration());

        }

}
