namespace TennisScores.Data.Models
{
    public class Venue
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public Tournament Tournaments { get; set; } = null!;
    }
}
