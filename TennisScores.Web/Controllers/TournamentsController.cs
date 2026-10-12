using Microsoft.AspNetCore.Mvc;

namespace TennisScores.Web.Controllers
{
    public class TournamentsController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }
    }
}
