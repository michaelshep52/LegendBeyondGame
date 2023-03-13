using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class InventoryRepository : LegendRepository<Inventory>, IInventoryRepository
    {
        public InventoryRepository(LegendContext context) : base(context)
        {
        }
    }
}

