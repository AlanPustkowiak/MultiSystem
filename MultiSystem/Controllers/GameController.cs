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

        [HttpGet("all")]
        public async Task<ActionResult<List<Game>>> GetAllGames()
        {
            var games = await _gameService.GetAllGames();
            return games;
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGame(Game game)
        {
            var addedGame = await _gameService.AddGame(game);
            return Ok(addedGame);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<Game>> EditGame(int Id, Game game)
        {
            var editedGame = await _gameService.EditGame(Id, game);
            return Ok(editedGame);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<bool>> DeleteGame(int Id)
        {
            var result = await _gameService.DeleteGame(Id);
            return Ok(result);
        }
    }
}
