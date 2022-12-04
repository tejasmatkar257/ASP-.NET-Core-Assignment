using FootballLeagueManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueManagement.Controllers
{
    public class FootballLeagueController : Controller
    {
        private readonly FootballLeagueDbContext _context;
        public FootballLeagueController(FootballLeagueDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<FootballLeague> objCatlist = _context.FootballLeagues;
            return View(objCatlist);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FootballLeague Football)
        {
            if (ModelState.IsValid)
            {
                _context.FootballLeagues.Add(Football);
                _context.SaveChanges();
                TempData["ResultOk"] = "Record Added Successfully !";
                return RedirectToAction("Index");
            }

            return View(Football);
        }
    }
}