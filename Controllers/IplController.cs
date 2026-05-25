
using Microsoft.AspNetCore.Mvc;
using myapp.Data;
using myapp.Models;
using System.Linq;

namespace myapp.Controllers
{
    public class IplController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IplController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var iplData = _context.IplData.ToList();
            return View(iplData);
        }
    }
}
