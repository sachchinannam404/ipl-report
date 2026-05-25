
using Microsoft.EntityFrameworkCore;
using myapp.Models;

namespace myapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<IplData> IplData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .HasMany(t => t.Players)
                .WithOne(p => p.Team)
                .HasForeignKey(p => p.TeamId);
        }
    }
}
