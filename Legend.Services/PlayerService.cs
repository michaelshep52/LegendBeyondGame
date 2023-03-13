using System;
using System.Numerics;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Legend.Services.Interfaces;

namespace Legend.Services
{
    public class PlayerService : IPlayerService
    {
        public IUnitOfWork _unitOfWork;

        public PlayerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreatePlayer(Player player)
        {
            if (player != null)
            {
                await _unitOfWork.PlayerRepostiory.Add(player);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeletePlayer(int playerId)
        {
            if (playerId > 0)
            {
                var player = await _unitOfWork.PlayerRepostiory.GetById(playerId);
                if (player != null)
                {
                    _unitOfWork.PlayerRepostiory.Delete(player);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Player>> GetAllPlayers()
        {
            var playerList = await _unitOfWork.PlayerRepostiory.GetAll();
            return playerList;
        }

        public async Task<Player> GetPlayerById(int playerId)
        {
            if (playerId > 0)
            {
                var player = await _unitOfWork.PlayerRepostiory.GetById(playerId);
                if (player != null)
                {
                    return player;
                }
            }
            return null;
        }

        public async Task<bool> UpdatePlayer(Player player)
        {
            if (player != null)
            {
                var playerRepository = await _unitOfWork.PlayerRepostiory.GetById(player.PlayerId);
                if (playerRepository != null)
                {
                    playerRepository.AccountId = player.AccountId;
                    playerRepository.CharacterId = player.CharacterId;
                    playerRepository.InventoryId = player.InventoryId;
                    playerRepository.IsActive = player.IsActive;


                    _unitOfWork.PlayerRepostiory.Update(playerRepository);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }
    }
}

