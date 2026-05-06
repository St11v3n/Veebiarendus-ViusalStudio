using Microsoft.AspNetCore.Mvc;

namespace FullStackReact.Server.Controllers
{
    public class PlanetsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
