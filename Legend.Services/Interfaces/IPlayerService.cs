using System;
using Legend.Domain.Entities;

namespace Legend.Services.Interfaces
{
    public interface IPlayerService
    {
        Task<bool> CreatePlayer(Player player);

        Task<IEnumerable<Player>> GetAllPlayers();

        Task<Player> GetPlayerById(int playerId);

        Task<bool> UpdatePlayer(Player player);

        Task<bool> DeletePlayer(int playerId);

    }
}

