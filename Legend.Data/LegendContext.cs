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
        public DbSet<Player> Players { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
           => optionsBuilder.UseNpgsql("Host=localhost;Database=LegendGameData;Username=michaelshepherd;Password=Laelynes5267!");

        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             optionsBuilder.UseNpgsql(_config.GetConnectionString("LegendGameData"));
             //Add to help with migrations for Datetime timestamp!!!!
             AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

         }*/


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
              });

            bldr.Entity<Character>()
            .HasData(new
            {
                "characterId": 1,
                "name": "Gunner",
                "health": 6,
                "strength": 5,
                "speed": 6,
                "stamina": 7
            }, new
            {
                "characterId": 2,
                "name": "Defender",
                "health": 10,
                "strength": 10,
                "speed": 4,
                "stamina": 5
                
            }, new
            {
                CharacterId = 3,
                Name = "Ninja",
                Health = 6,
                Strength = 5,
                Speed = 8,
                Stamina = 7
            }, new
            {
                CharacterId = 4,
                Name = "Healer",
                Health = 5,
                Strength = 5,
                Speed = 6,
                Stamina = 6
            }, new
            {
                CharacterId = 5,
                Name = "Sniper",
                Health = 7,
                Strength = 5,
                Speed = 7,
                Stamina = 7
            }, new
            {
                CharacterId = 6,
                Name = "Runner",
                Health = 7,
                Strength = 5,
                Speed = 10,
                Stamina = 8
            }, new
            {
                CharacterId = 7,
                Name = "Ghost",
                Health = 8,
                Strength = 7,
                Speed = 8,
                Stamina = 8
            });

            bldr.Entity<Inventory>()
                        .HasData(new
                        {
                            InventoryId = 1,
                            Name = "Assault rife",
                            Damage = 5,
                            Type = "Gun"
                        }, new
                        {
                            InventoryId = 2,
                            Name = "Shotgun",
                            Damage = 5,
                            Type = "Gun"
                        }, new
                        {
                            InventoryId = 3,
                            Name = "Katana",
                            Damage = 5,
                            Type = "Sword"
                        }, new
                        {
                            InventoryId = 4,
                            Name = "Sniper",
                            Damage = 5,
                            Type = "Gun"
                        }, new
                        {
                            InventoryId = 5,
                            Name = "Bowie",
                            Damage = 5,
                            Type = "Knife"
                        }, new
                        {
                            InventoryId = 6,
                            Name = "Silenced Sniper",
                            Damage = 5,
                            Type = "Gun"
                        }, new
                        {
                            InventoryId = 7,
                            Name = "Health Blaster",
                            Damage = 5,
                            Type = "Gun"
                        });
        }*/
    }
}
