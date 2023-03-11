using System;
using Legend.Domain.Entities;

namespace Legend.Data
{
   /* public static class DbInitializer
    {
        public static void Initialize(LegendContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
            {
                 new User{UserId=0, UserName="Michaelshep", Password="Password1234", FirstName="Michael", LastName="Shepherd", Email="michaelshep52@gmail.com", Phone="6064384485", IsActive=true}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            var characters = new Character[]
            {
        new Character{CharacterId=0, Name="Gunner", Health=6, Speed=6, Stamina=7, Strength=5, IsActive=true},
        new Character{CharacterId=1, Name="Defender", Health=10, Speed=4, Stamina=5, Strength=10, IsActive=true},
        new Character{CharacterId=2, Name="Ninja", Health=6, Speed=8, Stamina=7, Strength=5, IsActive=true},
        new Character{CharacterId=3, Name="Healer", Health=5, Speed=6, Stamina=6, Strength=5, IsActive=true},
        new Character{CharacterId=4, Name="Sniper", Health=7, Speed=7, Stamina=7, Strength=5, IsActive=true},
        new Character{CharacterId=5, Name="Runner", Health=7, Speed=10, Stamina=8, Strength=5, IsActive=true},
        new Character{CharacterId=6, Name="Ghost", Health=8, Speed=8, Stamina=8, Strength=7, IsActive=true},
            };
            foreach (Character c in characters)
            {
                context.Characters.Add(c);
            }
            context.SaveChanges();

            var missions = new Mission[]
            {
        new Mission{MissionId=0, Name="Getting Started", Text="Kill 1 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=1, Name="Bot", Text="Kill 10 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=2, Name="Starting somewhere", Text="Kill 20 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=3, Name="Building a RESUME", Text="Kill 40 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=4, Name="Your a savage", Text="Kill 50 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=5, Name="King Slayer", Text="Kill 75 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=6, Name="Duty Calls", Text="Kill 85 Enemy without Dying!", IsActive=true},
        new Mission{MissionId=7, Name="Best to ever be", Text="Kill 100 Enemy without Dying!", IsActive=true},
            };
            foreach (Mission e in missions)
            {
                context.Missions.Add(e);
            }
            context.SaveChanges();
        }
    }*/
    
}

