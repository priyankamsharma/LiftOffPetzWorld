using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.Controllers
{
    public class SearchPetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
