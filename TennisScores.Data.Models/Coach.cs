namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static TennisScores.Common.ValidationConstants.Coach;

    public class Coach
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public required string LastName { get; set; }

        public required int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        public Player Player { get; set; } = null!;
    }
}
