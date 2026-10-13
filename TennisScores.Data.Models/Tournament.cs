using TennisScores.Common.MatchEnumerations;

namespace TennisScores.Data.Models
{
    public class Tournament
    {
        public int Id { get; set; }

        //example value Almaty Open
        public required string TournamentName { get; set; }

        //example value Almaty, Kazakhstan
        public required string Location { get; set; }

        //example value 19 October 2026
        public required DateTime StartDate { get; set; }

        //example value 25 October 2026
        public required DateTime EndDate { get; set; }

        //example value ATP 250
        public required string TournamentType { get; set; }

        //the variants are Grass, Clay, Hard, Carpet 
        public required CourtSurface CourtSurface { get; set; }

        //the variants are Indoor, Outdoor
        public required CourtEnvironment CourtEnvironment { get; set; }

        public virtual ICollection<Venue> Venues { get; set; } =
            new HashSet<Venue>();
    }
}
