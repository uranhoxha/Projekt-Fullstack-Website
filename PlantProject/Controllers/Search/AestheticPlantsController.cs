using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantProject.Data;
using PlantProject.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PlantProject.Controllers
{
    public class AestheticPlantsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AestheticPlantsController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(string searchName, string searchSeason, string searchColor, string searchEnvironment) //Plant.cs table
        {
            if (_db.AestheticPlants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.AestheticPlants' is null.");
            }

            var plants = from p in _db.AestheticPlants
                         select p;

            if (!string.IsNullOrEmpty(searchName))
            {
                plants = plants.Where(p => p.Name.Contains(searchName));
            }

            if (!string.IsNullOrEmpty(searchSeason))
            {
                plants = plants.Where(p => p.Season.Contains(searchSeason));
            }

            if (!string.IsNullOrEmpty(searchColor))
            {
                plants = plants.Where(p => p.Color.Contains(searchColor));
            }
            if (!string.IsNullOrEmpty(searchEnvironment))
            {
                plants = plants.Where(p => p.Environment.Contains(searchEnvironment));
            }

            return View("~/Views/Search/AestheticPlants/Index.cshtml", await plants.ToListAsync());
        }

        public IActionResult Details(int id)
        {
            var plant = _db.AestheticPlants.FirstOrDefault(p => p.Id == id);
            if (plant == null)
            {
                return NotFound();
            }
            return View("~/Views/Search/AestheticPlants/Details.cshtml" , plant);
        }
    }
}
