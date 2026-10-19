namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static TennisScores.Common.ValidationConstants.Venue;
    public class Venue
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }

        public virtual ICollection<TournamentVenue> TournamentVenues { get; set; } =
            new HashSet<TournamentVenue>();
    }
}
