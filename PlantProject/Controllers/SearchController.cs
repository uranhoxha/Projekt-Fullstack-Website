using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantProject.Data;
using PlantProject.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PlantProject.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationDbContext _db;

        
        public SearchController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string searchName, string searchSeason, string searchType)
        {
            if (_db.Plants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Plants' is null.");
            }

            var plants = from p in _db.Plants
                         select p;

            if (!string.IsNullOrEmpty(searchName))
            {
                plants = plants.Where(p => p.Name.Contains(searchName));
            }

            if (!string.IsNullOrEmpty(searchSeason))
            {
                plants = plants.Where(p => p.Season.Contains(searchSeason));
            }

            if (!string.IsNullOrEmpty(searchType))
            {
                plants = plants.Where(p => p.Type.Contains(searchType));
            }

            return View(await plants.ToListAsync());
        }
    }
}
