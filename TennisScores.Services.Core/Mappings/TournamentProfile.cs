namespace TennisScores.Services.Core.Mappings
{
    using AutoMapper;
    using TennisScores.Data.Models;
    using TennisScores.ViewModels.Tournaments;

    public class TournamentProfile : Profile
    {
        public TournamentProfile()
        {
            this.CreateMap<TournamentFormViewModel, Tournament>();
            this.CreateMap<Tournament, TournamentFormViewModel>();

            this.CreateMap<Tournament, TournamentDetailsViewModel>();

            this.CreateMap<Tournament, TournamentInfoViewModel>();
        }
    }
}
