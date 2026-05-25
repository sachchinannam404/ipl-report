
using Microsoft.EntityFrameworkCore;
using myapp.Models;
using System;
using System.IO;
using System.Linq;

namespace myapp.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any IPL data.
                if (context.IplData.Any())
                {
                    return;   // DB has been seeded
                }

                var iplData = new StreamReader("Data/ipl.csv");
                var iplDataList = iplData.ReadToEnd().Split('\n').Skip(1).ToList();

                foreach (var row in iplDataList)
                {
                    if (string.IsNullOrEmpty(row)) continue;
                    var columns = row.Split(',');
                    context.IplData.AddRange(
                        new IplData
                        {
                            Season = int.Parse(columns[0]),
                            Team1 = columns[1],
                            Team2 = columns[2],
                            TossWinner = columns[3],
                            TossDecision = columns[4],
                            Winner = columns[5],
                            PlayerOfMatch = columns[6],
                            Venue = columns[7],
                            City = columns[8]
                        }
                    );
                }

                context.SaveChanges();
            }
        }
    }
}
