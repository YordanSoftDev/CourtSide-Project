namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Common.MatchEnumerations;
    using TennisScores.Data.Models;

    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public static IEnumerable<Match> DefaultMatches =>
            new List<Match>
            {
                new Match
                {
                    Id = 1,
                    FirstPlayerId = 81,
                    SecondPlayerId = 65,
                    TournamentId = 1, // ATP Lyon Open
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 23, 30, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "2h 15m",
                    ScoreResult = "6-7 7-6 2-6",
                    WinnerId = 65
                },
                // 2. Matteo Berrettini (25) vs Kyrian Jacquet (82) -> Winner: Jacquet (82)
                new Match
                {
                    Id = 2,
                    FirstPlayerId = 25,
                    SecondPlayerId = 82,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 21, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 1",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "1h 40m",
                    ScoreResult = "6-7 5-7",
                    WinnerId = 82
                },
                // 3. Luca Van Assche (85) vs Clément Tabur (83) -> Winner: Van Assche (85)
                new Match
                {
                    Id = 3,
                    FirstPlayerId = 85,
                    SecondPlayerId = 83,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 20, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 2",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "1h 35m",
                    ScoreResult = "7-6 6-3",
                    WinnerId = 85
                },
                // 4. Benjamin Bonzi (84) vs Cameron Norrie (22) -> Winner: Bonzi (84)
                new Match
                {
                    Id = 4,
                    FirstPlayerId = 84,
                    SecondPlayerId = 22,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 18, 50, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "2h 05m",
                    ScoreResult = "6-3 3-6 6-3",
                    WinnerId = 84
                },
                // 5. Daniel Altmaier (52) vs Titouan Droguet (86) -> Winner: Altmaier (52)
                new Match
                {
                    Id = 5,
                    FirstPlayerId = 52,
                    SecondPlayerId = 86,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 17, 05, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 1",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "2h 30m",
                    ScoreResult = "5-7 7-6 7-6",
                    WinnerId = 52
                },
                // 6. Ugo Humbert (16) vs Corentin Moutet (87) -> Winner: Moutet (87)
                new Match
                {
                    Id = 6,
                    FirstPlayerId = 16,
                    SecondPlayerId = 87,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 15, 15, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "2h 20m",
                    ScoreResult = "2-6 7-6 4-7",
                    WinnerId = 87
                },
                // 7. Arthur Féry (88) vs Borna Gojo (89) -> Winner: Gojo (89)
                new Match
                {
                    Id = 7,
                    FirstPlayerId = 88,
                    SecondPlayerId = 89,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 15, 05, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 2",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "1h 25m",
                    ScoreResult = "3-6 2-7",
                    WinnerId = 89
                },
                // 8. Pierre-Hugues Herbert (90) vs Sebastian Baez (27) -> Winner: Herbert (90)
                new Match
                {
                    Id = 8,
                    FirstPlayerId = 90,
                    SecondPlayerId = 27,
                    TournamentId = 1,
                    VenueId = 11,
                    DateTime = new DateTime(2026, 10, 20, 13, 05, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Clay,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.FirstRound,
                    MatchStatus = MatchStatus.Completed,
                    MatchDuration = "1h 30m",
                    ScoreResult = "6-3 6-4",
                    WinnerId = 90
                }
            };

        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.Property(m => m.MatchStatus)
                .HasConversion<string>();

            builder.Property(m => m.MatchRound)
                .HasConversion<string>();

            builder.Property(m => m.CourtSurface)
                .HasConversion<string>();

            builder.HasData(DefaultMatches);
        }
    }
}
