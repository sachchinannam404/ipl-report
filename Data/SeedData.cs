
using Microsoft.EntityFrameworkCore;
using myapp.Models;

namespace myapp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any players.
                if (context.Players.Any())
                {
                    return;   // DB has been seeded
                }

                context.Players.AddRange(
                    new Player
                    {
                        Name = "Shohei Ohtani",
                        Team = "Los Angeles Dodgers",
                        Role = "Designated Hitter",
                        Batting = "Left",
                        Throwing = "Right"
                    },
                    new Player
                    {
                        Name = "Mookie Betts",
                        Team = "Los Angeles Dodgers",
                        Role = "Shortstop",
                        Batting = "Right",
                        Throwing = "Right"
                    },
                    new Player
                    {
                        Name = "Freddie Freeman",
                        Team = "Los Angeles Dodgers",
                        Role = "First Baseman",
                        Batting = "Left",
                        Throwing = "Right"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
