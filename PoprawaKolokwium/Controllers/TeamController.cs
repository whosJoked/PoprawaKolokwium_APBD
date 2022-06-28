using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PoprawaKolokwium.Services;
using System.Threading.Tasks;

namespace PoprawaKolokwium.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IDbService _dbService;

        public TeamController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        [Route("Team/{teamId}")]
        public async Task<IActionResult> GetTeamById(int teamId)
        {
            return Ok(await _dbService.GetTeamById(teamId));
        }
    }
}
