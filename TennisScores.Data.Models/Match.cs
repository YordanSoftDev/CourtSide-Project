namespace TennisScores.Data.Models
{
    using TennisScores.Common.MatchEnumerations;
    public class Match
    {
        public int Id { get; set; }

        public int FirstPlayerId { get; set; }

        public virtual Player FirstPlayer { get; set; } = null!;

        public int SecondPlayerId { get; set; }

        public virtual Player SecondPlayer { get; set; } = null!;

        public required DateTime DateTime { get; set; }

        //The variants are Sheduled, In Progress, Completed, Cancelled 
        public required MatchStatus MatchStatus { get; set; }

        //The variants are Grass, Clay, Hard and Carpet
        public required MatchRound MatchRound { get; set; }

        public required string CourtName { get; set; }

        //The venue(tennis club or a stadium)
        //where the match will be played or was played
        public int VenueId { get; set; }

        public virtual Venue Venue { get; set; } = null!;

        public int TournamentId { get; set; }

        public virtual Tournament Tournament { get; set; } = null!;

        public string? ScoreResult { get; set; }

        public int? WinnerId { get; set; }

        public virtual Player? Winner { get; set; }
    }
}
