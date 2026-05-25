using Microsoft.AspNetCore.Mvc.RazorPages;
using myapp.Data;
using myapp.Models;

namespace myapp.Pages;

public class TeamsModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public TeamsModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Team> Teams { get; set; } = new List<Team>();

    public void OnGet()
    {
        Teams = _context.Teams.ToList();
    }
}
