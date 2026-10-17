namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TennisScores.Common.MatchEnumerations;
    public class Match
    {
        public int Id { get; set; }

        public required int FirstPlayerId { get; set; }
        [ForeignKey(nameof(FirstPlayerId))]
        public virtual Player FirstPlayer { get; set; } = null!;

        public required int SecondPlayerId { get; set; }

        [ForeignKey(nameof(SecondPlayerId))]
        public virtual Player SecondPlayer { get; set; } = null!;

        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime DateTime { get; set; }

        //The variants are Sheduled, In Progress, Completed, Cancelled 
        [MaxLength(20)]
        public required MatchStatus MatchStatus { get; set; }

        [MaxLength(20)]
        public required MatchRound MatchRound { get; set; }

        //The variants are Grass, Clay, Hard and Carpet
        [MaxLength(20)]
        public required CourtSurface CourtSurface { get; set; }

        [Required]
        [MaxLength(100)]
        public required string CourtName { get; set; }

        //The variants are Indoor and Outdoor
        [MaxLength(20)]
        public required CourtEnvironment? CourtEnvironment { get; set; }

        //The venue(tennis club or a stadium)
        //where the match will be played or was played
        public required int VenueId { get; set; }
        [ForeignKey(nameof(VenueId))]
        public virtual Venue Venue { get; set; } = null!;

        public required int TournamentId { get; set; }
        [ForeignKey(nameof(TournamentId))]
        public virtual Tournament Tournament { get; set; } = null!;

        [MaxLength(100)]
        public string? ScoreResult { get; set; }

        public int? WinnerId { get; set; }
        [ForeignKey(nameof(WinnerId))]
        public virtual Player? Winner { get; set; }
    }
}
