namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static TennisScores.Common.ValidationConstants.Player;

    public class Player
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public required string LastName { get; set; }

        public required int Age { get; set; }

        //example value 170 lbs/(77kg)
        [Required]
        [MaxLength(WeightMaxLength)]
        public required string Weight { get; set; }

        //example value 6'3"/(191cm)
        [Required]
        [MaxLength(HeightMaxLength)]
        public required string Height { get; set; }

        public required int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;

        [Required]
        [MaxLength(BirthplaceMaxLength)]
        public required string Birthplace { get; set; }

        public required int Rank { get; set; }

        public ICollection<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
