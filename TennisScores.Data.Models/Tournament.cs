namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using TennisScores.Common.MatchEnumerations;
    public class Tournament
    {
        public int Id { get; set; }

        //example value Almaty Open
        [Required]
        [MaxLength(100)]
        public required string TournamentName { get; set; }

        //example value Almaty, Kazakhstan
        [Required]
        [MaxLength(100)]
        public required string Location { get; set; }

        //example value 19 October 2026
        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime StartDate { get; set; }

        //example value 25 October 2026
        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime EndDate { get; set; }

        //example value ATP 250
        [Required]
        [MaxLength(50)]
        public required string TournamentType { get; set; }

        //the variants are Grass, Clay, Hard, Carpet 
        [MaxLength(20)]
        public required CourtSurface CourtSurface { get; set; }

        //the variants are Indoor, Outdoor
        [MaxLength(20)]
        public required CourtEnvironment CourtEnvironment { get; set; }

        public required bool IsActive { get; set; } 

        public virtual ICollection<TournamentVenue> TournamentVenues { get; set; } =
            new HashSet<TournamentVenue>(); 
    }
}
