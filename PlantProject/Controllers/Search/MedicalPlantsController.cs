using Microsoft.AspNetCore.Mvc;

namespace PlantProject.Controllers.Search
{
    public class MedicalPlantsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
