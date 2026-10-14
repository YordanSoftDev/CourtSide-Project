namespace TennisScores.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TennisScores.Services.Core.Contracts;
    using TennisScores.ViewModels.Tournaments;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentService service;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.service = tournamentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index() //My tournaments
        {
            //string? userId = this.GetUserId();

            IEnumerable<TournamentInfoViewModel>? tournaments = 
                await this.service
                .GetAllTournamentsForIndexAsync(/*userId*/);
            return this.View(tournaments);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) //Tournament overview
        {
            //string? userId = this.GetUserId();
            TournamentDetailsViewModel? tournamentModel = await this
                .service.GetTournamentDetailsByIdAsync(id /*userId*/);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            return this.View(tournamentModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create() //Display the form to register a new tournament
        {
            TournamentFormViewModel? model = new TournamentFormViewModel();
            await this.service.PopulateDropdownsAsync(model);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create //Process and save the new tournament submission 
            (TournamentFormViewModel model)  
        {
            if (!this.ModelState.IsValid)
            {
                await this.service.PopulateDropdownsAsync(model);
                return this.View(model);
            }

            //string? userId = this.GetUserId();

            int createdId = await this.service
                .CreateTournamentAsync(model /*userId*/);
            return this.RedirectToAction(nameof(Details), new { id = createdId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) //Display the form to edit an existing tournament
        {
            string? userId = this.GetUserId();
            TournamentFormViewModel? model = await this.service
                .GetTournamentForEditByIdAsync(id /*userId*/);

            if (model == null)
            {
                return this.NotFound();
            }

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TournamentFormViewModel model) //Process and save the updated tournament changes 
        {
            if (!this.ModelState.IsValid)
            {
                await this.service.PopulateDropdownsAsync(model);
                return this.View(model);
            }

            string? userId = this.GetUserId();

            bool isUpdated = await this.service
                .UpdateTournamentAsync(id, model /*userId*/);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) //Display the delete confirmation page for a tournament
        {
            string? userId = this.GetUserId();
            TournamentDetailsViewModel? tournamentModel = await 
                this.service.GetTournamentDetailsByIdAsync(id /*userId*/);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            return this.View(tournamentModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //Process and permanently delete the tournament record
        {
            string? userId = this.GetUserId(); 
            bool isDeleted = await this.service.DeleteTournamentAsync(id /*userId*/);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}