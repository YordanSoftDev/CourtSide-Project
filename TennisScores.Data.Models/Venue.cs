namespace TennisScores.Data.Models
{
    public class Venue
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public virtual Tournament Tournament { get; set; } = null!;
    }
}
