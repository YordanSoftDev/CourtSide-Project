namespace TennisScores.Data.Models
{
    public class Coach
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required int PlayerId { get; set; }

        public Player Player { get; set; } = null!;
    }
}
