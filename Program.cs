
using Microsoft.EntityFrameworkCore;
using myapp.Data;
using myapp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

var app = builder.Build();

// Seed the database
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();
    SeedData(context);
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

static void SeedData(ApplicationDbContext context)
{
    if (context.Players.Any() || context.Teams.Any() || context.Coaches.Any())
    {
        return;   // DB has been seeded
    }

    var players = new Player[]
    {
        new Player{Name="Virat Kohli", Team="Royal Challengers Bengaluru"},
        new Player{Name="Rohit Sharma", Team="Mumbai Indians"},
        new Player{Name="MS Dhoni", Team="Chennai Super Kings"}
    };
    context.Players.AddRange(players);

    var teams = new Team[]
    {
        new Team{Name="Royal Challengers Bengaluru", Coach="Andy Flower"},
        new Team{Name="Mumbai Indians", Coach="Mark Boucher"},
        new Team{Name="Chennai Super Kings", Coach="Stephen Fleming"}
    };
    context.Teams.AddRange(teams);
    
    var coaches = new Coach[]
    {
        new Coach{Name="Andy Flower", Team="Royal Challengers Bengaluru"},
        new Coach{Name="Mark Boucher", Team="Mumbai Indians"},
        new Coach{Name="Stephen Fleming", Team="Chennai Super Kings"}
    };
    context.Coaches.AddRange(coaches);
    
    context.SaveChanges();
}
