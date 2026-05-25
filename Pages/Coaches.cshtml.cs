using Microsoft.AspNetCore.Mvc.RazorPages;
using myapp.Data;
using myapp.Models;
using System.Collections.Generic;
using System.Linq;

namespace myapp.Pages
{
    public class CoachesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CoachesModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Coach> Coaches { get;set; }

        public void OnGet()
        {
            Coaches = _context.Coaches.ToList();
        }
    }
}
