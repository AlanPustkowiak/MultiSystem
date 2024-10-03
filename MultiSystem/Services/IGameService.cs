using MultiSystem.Shared.Data;
using MultiSystem.Shared.Entity;

namespace MultiSystem.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGame(Game game);
    }
}
