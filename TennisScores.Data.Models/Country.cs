using System.ComponentModel.DataAnnotations;

namespace TennisScores.Data.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }
    }
}
