using myapp.Data;
using myapp.Models;
using System.Globalization;
using CsvHelper;

namespace myapp.Services
{
    public class SeedDataService
    {
        private readonly IServiceProvider _serviceProvider;

        public SeedDataService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task InitializeAsync()
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (!context.Players.Any())
                {
                    using (var reader = new StreamReader("Data/players.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Player>();
                        context.Players.AddRange(records);
                        await context.SaveChangesAsync();
                    }
                }

                if (!context.Teams.Any())
                {
                    using (var reader = new StreamReader("Data/ipl.csv"))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var records = csv.GetRecords<Team>();
                        context.Teams.AddRange(records);
                        await context.SaveChangesAsync();
                    }
                }

                // For now, we will not be seeding coaches.
            }
        }
    }
}
