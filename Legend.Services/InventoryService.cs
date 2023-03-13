using System;
using Legend.Data.Repositories;
using Legend.Domain.Entities;
using Legend.Domain.Interface;
using Legend.Services.Interfaces;

namespace Legend.Services
{
    public class InventoryService : IInventoryService
    {
        public IUnitOfWork _unitOfWork;

        public InventoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateInventory(Inventory inventory)
        {
            if (inventory != null)
            {
                await _unitOfWork.InventoryRepostiory.Add(inventory);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }

        public async Task<bool> DeleteInventory(int inventoryId)
        {
            if (inventoryId > 0)
            {
                var inventory = await _unitOfWork.InventoryRepostiory.GetById(inventoryId);
                if (inventory != null)
                {
                    _unitOfWork.InventoryRepostiory.Delete(inventory);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Inventory>> GetAllInventory()
        {
            var InventoryList = await _unitOfWork.InventoryRepostiory.GetAll();
            return InventoryList;
        }

        public async Task<Inventory> GetInventoryById(int inventoryId)
        {
            if (inventoryId > 0)
            {
                var inventory = await _unitOfWork.InventoryRepostiory.GetById(inventoryId);
                if (inventory != null)
                {
                    return inventory;
                }
            }
            return null;
        }

        public async Task<bool> UpdateInventory(Inventory inventory)
        {
            if (inventory != null)
            {
                var inventoryRepostiory = await _unitOfWork.InventoryRepostiory.GetById(inventory.InventoryId);
                if (inventoryRepostiory != null)
                {
                    inventoryRepostiory.Name = inventory.Name;
                    inventoryRepostiory.Damage = inventory.Damage;
                    inventoryRepostiory.Type = inventory.Type;

                    _unitOfWork.InventoryRepostiory.Update(inventoryRepostiory);

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


