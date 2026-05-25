
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using myapp.Data;
using myapp.Models;

namespace myapp.Pages
{
    public class PlayersModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public PlayersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Player> Players { get; set; }

        public void OnGet()
        {
            Players = _context.Players.ToList();
        }
    }
}
