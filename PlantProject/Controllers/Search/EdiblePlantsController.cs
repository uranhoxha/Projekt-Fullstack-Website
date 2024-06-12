using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantProject.Data;
using PlantProject.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PlantProject.Controllers
{
    public class EdiblePlantsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EdiblePlantsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string searchName, string searchSeason, string searchType, string searchEnvironment) //Plant.cs table
        {
            if (_db.EdiblePlants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EdiblePlants' is null.");
            }

            var plants = from p in _db.EdiblePlants
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
            if (!string.IsNullOrEmpty(searchEnvironment))
            {
                plants = plants.Where(p => p.Environment.Contains(searchEnvironment));
            }

            return View("~/Views/Search/EdiblePlants/Index.cshtml", await plants.ToListAsync());
        }

        public IActionResult Details(int id)
        {
            var plant = _db.EdiblePlants.FirstOrDefault(p => p.Id == id);
            if (plant == null)
            {
                return NotFound();
            }
            return View("~/Views/Search/EdiblePlants/Details.cshtml", plant);
        }
    }
}
