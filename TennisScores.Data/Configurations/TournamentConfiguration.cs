namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Common.MatchEnumerations;
    using TennisScores.Data.Models;

    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public static IEnumerable<Tournament> DefaultTournaments =>
             new List<Tournament>
             {
                 new Tournament
                 {
                     Id = 1,
                     TournamentName = "Wimbledon",
                     Location = "London, United Kingdom",
                     StartDate = new DateTime(2026, 6, 29, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 7, 12, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam",
                     CourtSurface = CourtSurface.Grass,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 2,
                     TournamentName = "Roland Garros",
                     Location = "Paris, France",
                     StartDate = new DateTime(2026, 5, 25, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 6, 7, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 3,
                     TournamentName = "US Open",
                     Location = "New York, USA",
                     StartDate = new DateTime(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 9, 13, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 4,
                     TournamentName = "Almaty Open",
                     Location = "Almaty, Kazakhstan",
                     StartDate = new DateTime(2026, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 10, 25, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 5,
                     TournamentName = "Australian Open",
                     Location = "Melbourne, Australia",
                     StartDate = new DateTime(2026, 1, 18, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 1, 31, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 6,
                     TournamentName = "Monte-Carlo Masters",
                     Location = "Roquebrune-Cap-Martin, France",
                     StartDate = new DateTime(2026, 4, 12, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 4, 19, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 7,
                     TournamentName = "Mutua Madrid Open",
                     Location = "Madrid, Spain",
                     StartDate = new DateTime(2026, 5, 4, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5, 17, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 8,
                     TournamentName = "Italian Open",
                     Location = "Rome, Italy",
                     StartDate = new DateTime(2026, 5, 11, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5, 24, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 9,
                     TournamentName = "Cinch Championships",
                     Location = "London, United Kingdom",
                     StartDate = new DateTime(2026, 6, 15, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 500",
                     CourtSurface = CourtSurface.Grass,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                     IsActive = true
                 },
                 new Tournament
                 {
                     Id = 10,
                     TournamentName = "Swiss Indoors Basel",
                     Location = "Basel, Switzerland",
                     StartDate = new DateTime(2026, 10, 26, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11, 1, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 500",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                     IsActive = true
                 }
             };
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.Property(t => t.CourtSurface)
                .HasConversion<string>();

            builder.Property(t => t.CourtEnvironment)
               .HasConversion<string>();

            builder.HasMany(v => v.TournamentVenues)
           .WithOne(tv => tv.Tournament)
           .HasForeignKey(tv => tv.TournamentId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultTournaments);
        }
    }
}
