using System;
using System.Diagnostics;
using Legend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Legend.Data
{
    public class LegendContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Mission> Missions { get; set; }
        public DbSet<SideMission> SubMissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
               => optionsBuilder.UseNpgsql(
                   "Host=localhost;Database=LegendGameData;Username=michaelshepherd;Password=Laelynes5267!",
               options => options.MaxBatchSize(100))
               .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                               //DbLoggerCategory.Database.Transaction.Name},
                               LogLevel.Debug)
                   .EnableSensitiveDataLogging();

    }
}

