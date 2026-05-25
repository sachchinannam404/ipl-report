using Microsoft.AspNetCore.Mvc.RazorPages;
using myapp.Data;

namespace myapp.Pages;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public IndexModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public int PlayerCount { get; set; }
    public int TeamCount { get; set; }
    public int CoachCount { get; set; }

    public void OnGet()
    {
        PlayerCount = _context.Players.Count();
        TeamCount = _context.Teams.Count();
        CoachCount = _context.Coaches.Count();
    }
}
