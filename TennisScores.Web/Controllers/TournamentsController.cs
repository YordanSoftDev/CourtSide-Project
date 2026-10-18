namespace TennisScores.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using TennisScores.Services.Core.Contracts;
    using TennisScores.ViewModels.Tournaments;

    public class TournamentsController : Controller
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

            if (id <= 0)
            {
                return this.BadRequest();
            }

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

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create //Process and save the new tournament submission 
            (TournamentFormViewModel model)
        {
            if (model.StartDate > model.EndDate)
            {
                this.ModelState.AddModelError(nameof(model.EndDate),
                    "End data cannot be earlier than start date.");
            }

            if (!this.ModelState.IsValid)
            {
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
            if (id <= 0)
            {
                return this.BadRequest();
            }

            //string? userId = this.GetUserId();
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
            if (id <= 0)
            {
                return this.BadRequest();
            }

            if (model.StartDate > model.EndDate)
            {
                this.ModelState.AddModelError(nameof(model.EndDate),
                    "End date cannot be earlier than start date.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            //string? userId = this.GetUserId();

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
            if (id <= 0)
            {
                return this.BadRequest();
            }

            //string? userId = this.GetUserId();

            TournamentDetailsViewModel? tournamentModel = await
                this.service.GetTournamentDetailsByIdAsync(id /*userId*/);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            if (tournamentModel.IsActive)
            {
                this.TempData["ErrorMessage"] = "Active tournaments cannot be deleted.";
                return this.RedirectToAction(nameof(Details), new { id });
            }

            return this.View(tournamentModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //Process and permanently delete the tournament record
        {
            //string? userId = this.GetUserId(); 
            bool isDeleted = await this.service.DeleteTournamentAsync(id /*userId*/);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}