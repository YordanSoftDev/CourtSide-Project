namespace TennisScores.Data.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using TennisScores.Data.Models;

    public partial class TennisScoresDbContext : DbContext
    {
        public TennisScoresDbContext(DbContextOptions<TennisScoresDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Coach> Coaches { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<Tournament> TournamentVenues { get; set; } = null!;
        public virtual DbSet<Tournament> Venues { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TennisScoresDbContext).Assembly);

            this.OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
