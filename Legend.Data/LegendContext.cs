using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Legend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;

namespace Legend.Data
{
    public class LegendContextFactory : IDesignTimeDbContextFactory<LegendContext>
    {
        public LegendContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LegendContext>();
            optionsBuilder.UseNpgsql("Data Source=LegendBeyondGame.db");

            return new LegendContext(optionsBuilder.Options);
        }
    }
    public class LegendContext : DbContext
    {
        public LegendContext(DbContextOptions<LegendContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mission> Missions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
               => optionsBuilder.UseNpgsql(
                   "Host=localhost;Database=LegendGameData;Username=michaelshepherd;Password=Laelynes5267!",
               options => options.MaxBatchSize(100))
               .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name },
                               //DbLoggerCategory.Database.Transaction.Name},
                               LogLevel.Debug)
                   .EnableSensitiveDataLogging();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(s => s.Missions)
                .WithMany(b => b.Users)
                .UsingEntity<MissionUser>
                (bs => bs.HasOne<Mission>().WithMany(),
                bs => bs.HasOne<User>().WithMany());
        }
    }
}
