namespace TennisScores.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static TennisScores.Common.ValidationConstants.Country;
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }
    }
}
