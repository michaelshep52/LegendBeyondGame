using System;
using Legend.Domain.Entities;
using Legend.Domain.Interface;

namespace Legend.Data.Repositories
{
    public class MissionRepository : LegendRepository<Mission>, IMissionRepository
    {
        public MissionRepository(LegendContext context) : base(context)
        {

        }
    }
}

