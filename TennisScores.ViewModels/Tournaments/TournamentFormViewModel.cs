using TennisScores.Common.MatchEnumerations;

namespace TennisScores.ViewModels.Tournaments
{
    public class TournamentFormViewModel
    {
        public string Name { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Type { get; set; } = string.Empty;
 
        public CourtSurface CourtSurface { get; set; }

        public CourtEnvironment CourtEnvironment { get; set; }
    }
}
