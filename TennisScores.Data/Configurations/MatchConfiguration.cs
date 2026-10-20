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
                FirstPlayerId = 1,
                SecondPlayerId = 2,
                TournamentId = 1,
                VenueId = 1,
                DateTime = new DateTime(2026, 7, 12, 15, 0, 0, DateTimeKind.Utc),
                CourtSurface = CourtSurface.Grass,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Centre Court",
                MatchRound = MatchRound.Final,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "6-4 6-7 7-6 6-3",
                WinnerId = 1
            },
                new Match
            {
                Id = 2,
                FirstPlayerId = 3,
                SecondPlayerId = 4,
                TournamentId = 1,
                VenueId = 1,
                DateTime = new DateTime(2026,7,10,14,30,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Grass,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Court No. 1",
                MatchRound = MatchRound.Semifinal,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "6-3 6-2 6-4",
                WinnerId = 3
            },
            new Match
            {
                Id = 3,
                FirstPlayerId = 5,
                SecondPlayerId = 6,
                TournamentId = 2,
                VenueId = 2,
                DateTime = new DateTime(2026,6,7,16,0, 0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Clay,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Court Philippe-Chatrier",
                MatchRound = MatchRound.Final,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "6-1 6-3 4-6 5-7 6-2",
                WinnerId = 5
            },
            new Match
            {
                Id = 4,
                FirstPlayerId = 1,
                SecondPlayerId = 4,
                TournamentId = 2,
                VenueId = 2,
                DateTime = new DateTime(2026,6,5,13,0, 0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Clay,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Court Suzanne-Lenglen",
                MatchRound = MatchRound.Quarterfinal,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "7-5 6-4 6-2",
                WinnerId = 1
            },
            new Match
            {
                Id = 5,
                FirstPlayerId = 2,
                SecondPlayerId = 3,
                TournamentId = 3,
                VenueId = 3,
                DateTime = new DateTime(2026,9,13,20,0,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Arthur Ashe Stadium",
                MatchRound = MatchRound.Final,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "6-3 3-6 6-3 7-6",
                WinnerId = 2
            },
            new Match
            {
                Id = 6,
                FirstPlayerId = 5,
                SecondPlayerId = 1,
                TournamentId = 3,
                VenueId = 3,
                DateTime = new DateTime(2026,9,11,18,0,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Outdoor,
                CourtName = "Louis Armstrong Stadium",
                MatchRound = MatchRound.Semifinal,
                MatchStatus = MatchStatus.Completed,
                ScoreResult = "6-4 6-4 6-3",
                WinnerId = 5
            },
            new Match
            {
                Id = 7,
                FirstPlayerId = 6,
                SecondPlayerId = 2,
                TournamentId = 4,
                VenueId = 4,
                DateTime = new DateTime(2026,10,21,14,0,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Indoor,
                CourtName = "Center Court 1",
                MatchRound = MatchRound.FourthRound,
                MatchStatus = MatchStatus.InProgress,
                ScoreResult = "6-3 4-5",
                WinnerId = null
            },
            new Match
            {
                Id = 8,
                FirstPlayerId = 3,
                SecondPlayerId = 5,
                TournamentId = 4,
                VenueId = 4,
                DateTime = new DateTime(2026,10,21,16,30,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Indoor,
                CourtName = "Court 2",
                MatchRound = MatchRound.FourthRound,
                MatchStatus = MatchStatus.Scheduled,
                ScoreResult = null,
                WinnerId = null
            },
            new Match
            {
                Id = 9,
                FirstPlayerId = 4,
                SecondPlayerId = 6,
                TournamentId = 4,
                VenueId = 4,
                DateTime = new DateTime(2026,10,22,11,0,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Indoor,
                CourtName = "Center Court 1",
                MatchRound = MatchRound.Quarterfinal,
                MatchStatus = MatchStatus.Scheduled,
                ScoreResult = null,
                WinnerId = null
            },
            new Match
            {
                Id = 10,
                FirstPlayerId = 1,
                SecondPlayerId = 3,
                TournamentId = 4,
                VenueId = 4,
                DateTime = new DateTime(2026,10,10, 21, 10,0,0,DateTimeKind.Utc),
                CourtSurface = CourtSurface.Hard,
                CourtEnvironment = CourtEnvironment.Indoor,
                CourtName = "Court 3",
                MatchRound = MatchRound.FourthRound,
                MatchStatus = MatchStatus.Cancelled,
                ScoreResult = null,
                WinnerId = null
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
