using MultiSystem.Services;
using MultiSystem.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace MultiSystem.Shared.Services
{
    public class ClientGameService : IGameService
    {
        private readonly HttpClient _httpClient;

        public ClientGameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Game> AddGame(Game game)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/game", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public async Task<bool> DeleteGame(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/game/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/game/{id}", game);
            return await result.Content.ReadFromJsonAsync<Game>();
        }

        public async Task<List<Game>> GetAllGames()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Game>>("/api/game");
            return result;
        }

        public async Task<Game> GetGameById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Game>($"/api/game/{id}");
            return result;
        }
    }
}
