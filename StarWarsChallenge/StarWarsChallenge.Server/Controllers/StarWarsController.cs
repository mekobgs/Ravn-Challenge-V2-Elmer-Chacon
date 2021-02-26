using Microsoft.AspNetCore.Mvc;
using StarWarsChallenge.Service.Interfaces;
using System.Threading.Tasks;

namespace StarWarsChallenge.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarWarsController : ControllerBase
    {
        private readonly IStarWarsService _starWarsService;
        public StarWarsController(IStarWarsService starWarsService)
        {
            _starWarsService = starWarsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int page = 1)
        {
            var characters = await _starWarsService.GetPeople(page);
            return Ok(characters);
        }
    }
}
