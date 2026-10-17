using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisScores.Data.Models
{
    public class Coach
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(20)]
        public required string LastName { get; set; }

        public required int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;
    }
}
