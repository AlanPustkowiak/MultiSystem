using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiSystem.Services;
using MultiSystem.Shared.Entity;

namespace MultiSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<Game>> GetGameById(int Id)
        {
            var game = await _gameService.GetGameById(Id);
            return Ok(game);
        }
        //[HttpGet]
        //public async Task<ActionResult<Game>>

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var addedGame = await _gameService.AddGame(game);
            return Ok(addedGame);
        }
    }
}
