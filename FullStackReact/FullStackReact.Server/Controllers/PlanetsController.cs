using FullStackReact.Server.Controllers.Data;
using FullStackReact.Server.Controllers.Viewmodel;
using Microsoft.AspNetCore.Mvc;

namespace FullStackReact.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlanetsController : ControllerBase
    {
        private readonly PlanetContext _context;

        public PlanetsController
            (
                PlanetContext context
            )
        {
            _context = context;
        }
        public IActionResult SchoolIndex()
        {
            //muutuja resulti sisse pannakse domaini alt saadud info
            //mis antakse vaatesse returni juures
            //lsaks sellele antakse info edasi domaini modelist view modelisse
            var result = _context.Planets
                .Select(x => new PlanetsListViewModel
                { 
                    PlanetsId = x.PlanetsId,
                    Name = x.Name,
                    Description = x.Description,
                    Type = x.Type,
                    Mass = x.Mass
                });

            return Ok(result);
        }
    }
}
