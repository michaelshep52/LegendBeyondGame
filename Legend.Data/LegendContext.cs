using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Legend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Legend.Data
{
    public class LegendContext : DbContext
    {
        /*private readonly IConfiguration _config;

        public LegendContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }
        */
        public LegendContext(DbContextOptions<LegendContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Inventory> Inventories { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         //    => optionsBuilder.UseNpgsql("Host=localhost;Database=LegendGameData;Username=michaelshepherd;Password=Laelynes5267!");
        
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_config.GetConnectionString("LegendGameData"));
            //Add to help with migrations for Datetime timestamp!!!!
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        }*/
    }

    /*protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<Account>()
              .HasData(new
              {
                  AccountId = 1,
                  AccountName = "Michael Shepherd",
                  Password = "Password1234",
                  FirstName = "Michael",
                  LastName = "Shepherd",
                  Email = "michaelshep52@gmail.com",
                  Phone = 606 - 438 - 4485,
                  CharacterId = 1,
                  IsActive = true
              });

            bldr.Entity<Character>()
            .HasData(new
            {
                CharacterId = 1,
                Name = "Gunner",
                Health = 6,
                Speed = 6,
                Stamina = 7,
                Strength = 5,
                InventoryId = 1,
                IsActive = true
            }, new
            {
                CharacterId = 2,
                Name = "Defender",
                Health = 10,
                Speed = 4,
                Stamina = 5,
                Strength = 10,
                InventoryId = 2,
                IsActive = true
            }, new
            {
                CharacterId = 3,
                Name = "Ninja",
                Health = 6,
                Speed = 8,
                Stamina = 7,
                Strength = 5,
                InventoryId = 3,
                IsActive = true
            }, new
            {
                CharacterId = 4,
                Name = "Healer",
                Health = 5,
                Speed = 6,
                Stamina = 6,
                Strength = 5,
                IsActive = true
            }, new
            {
                CharacterId = 5,
                Name = "Sniper",
                Health = 7,
                Speed = 7,
                Stamina = 7,
                Strength = 5,
                InventoryId = 4,
                IsActive = true
            }, new
            {
                CharacterId = 6,
                Name = "Runner",
                Health = 7,
                Speed = 10,
                Stamina = 8,
                Strength = 5,
                InventoryId = 1,
                IsActive = true
            }, new
            {
                CharacterId = 7,
                Name = "Ghost",
                Health = 8,
                Speed = 8,
                Stamina = 8,
                Strength = 7,
                InventoryId = 3,
                IsActive = true
            });

            bldr.Entity<Inventory>()
                        .HasData(new
                        {
                            InventoryId = 1,
                            Name = "Assault rife",
                            Damage = 5,
                            Type = "Gun",
                            IsActive = true
                        }, new
                        {
                            InventoryId = 2,
                            Name = "Shotgun",
                            Damage = 5,
                            Type = "Gun",
                            IsActive = true
                        }, new
                        {
                            InventoryId = 3,
                            Name = "Katana",
                            Damage = 5,
                            Type = "Sword",
                            IsActive = true
                        }, new
                        {
                            InventoryId = 4,
                            Name = "Sniper",
                            Damage = 5,
                            Type = "Gun",
                            IsActive = true
                        });
        }
    }*/
}
