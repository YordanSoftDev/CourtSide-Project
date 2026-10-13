namespace TennisScores.ViewModels.Tournaments
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.ComponentModel.DataAnnotations;
    using TennisScores.Common.MatchEnumerations;

    public class TournamentFormViewModel
    {
        [Required(ErrorMessage = "Please select or enter a " +
                                 "tournament name.")]
        [StringLength(100, MinimumLength = 2, 
            ErrorMessage = "Tournament name must be between 2 and " +
                           "100 characters.")]
        [Display(Name = "Tournament Name")]
        public string? TournamentName { get; set; }

        public IEnumerable<SelectListItem> TournamentNames { get; set; }
                        = new List<SelectListItem>();

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(100, MinimumLength = 6,
            ErrorMessage = "Location must be between 6 " +
                           "and 100 characters.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Tournament type is required.")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Tournament type must be between 3 and " +
                           "50 characters.")]
        [Display(Name = "Tournament Type")]
        public string? TournamentType { get; set; }

        public IEnumerable<SelectListItem> TournamentTypes { get; set; }
                        = new List<SelectListItem>();

        [Required(ErrorMessage = "Please select a court surface.")]
        [Display(Name = "Court Surface")]
        public CourtSurface? CourtSurface { get; set; }

        [Required(ErrorMessage = "Please select a court environment.")]
        [Display(Name = "Court Environment")]
        public CourtEnvironment? CourtEnvironment { get; set; }      
    }
}
