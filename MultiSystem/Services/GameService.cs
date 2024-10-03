using Microsoft.EntityFrameworkCore;
using MultiSystem.Shared.Data;
using MultiSystem.Shared.Entity;

namespace MultiSystem.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _context;

        public GameService(DataContext context)
        {
            _context = context;
        }

        public async Task<Game> AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task<List<Game>> GetAllGames()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }
    }
}
