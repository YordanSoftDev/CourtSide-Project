namespace TennisScores.ViewModels.Tournaments
{
    using TennisScores.Common.MatchEnumerations;

    public class TournamentInfoViewModel
    {
        public int Id { get; set; }

        public string TournamentName { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TournamentType { get; set; } = string.Empty;

        public CourtSurface CourtSurface { get; set; }

        public CourtEnvironment CourtEnvironment { get; set; }
    }
}
