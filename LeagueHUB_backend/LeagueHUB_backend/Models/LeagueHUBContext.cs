using LeagueHUB_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace LeagueHUB_backend.Models


{
    public class LeagueHUBContext : DbContext
    {
        public LeagueHUBContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Referee> Referees { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder
optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database" +
            "=LeagueHUB; Integrated Security = True; Trusted_Connection =" +
            "true; MultipleActiveResultSets = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>()
                .HasOne(e => e.Home)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // <--

            modelBuilder.Entity<Game>()
                .HasOne(e => e.Guest)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict); // <--



        }
    }


}