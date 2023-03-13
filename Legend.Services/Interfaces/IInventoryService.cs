using System;
using Legend.Domain.Entities;

namespace Legend.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<bool> CreateInventory(Inventory inventory);

        Task<IEnumerable<Inventory>> GetAllInventory();

        Task<Inventory> GetInventoryById(int inventoryId);

        Task<bool> UpdateInventory(Inventory inventory);

        Task<bool> DeleteInventory(int inventoryId);
    }
}

