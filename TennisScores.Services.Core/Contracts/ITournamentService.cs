namespace TennisScores.Services.Core.Contracts
{
    using TennisScores.ViewModels.Tournaments;

    public interface ITournamentService
    {
        public Task<int> CreateTournamentAsync(TournamentFormViewModel tournamentForm /*int userId*/);

        public Task<bool> UpdateTournamentAsync(int id, TournamentFormViewModel tournamentForm /*int userId*/);

        public Task<bool> DeleteTournamentAsync(int id /*int userId*/);

        public Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(int id /*int userId*/);

        public Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(int id /*int userId*/);

        public Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync(/*int userId*/);
    }
}
