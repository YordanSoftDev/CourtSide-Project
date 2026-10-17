using System.ComponentModel.DataAnnotations;

namespace TennisScores.Data.Models
{
    public class Venue
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public virtual ICollection<TournamentVenue> TournamentVenues { get; set; } = 
            new HashSet<TournamentVenue>();
    }
}
