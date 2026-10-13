using TennisScores.ViewModels.Tournaments;

namespace TennisScores.Services.Core.Contracts
{
    public interface ITournamentService
    {
        public Task<int> CreateTournamentAsync(TournamentFormViewModel tournamentForm);

        public Task<bool> UpdateTournamentAsync(int id, TournamentFormViewModel tournamentForm);

        public Task<bool> DeleteTournamentAsync(int id);

        public Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(int id);

        public Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(int id);

        public Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync();

        Task PopulateDropdownsAsync(TournamentFormViewModel model);
    }
}
