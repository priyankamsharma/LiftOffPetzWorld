using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.Controllers
{
    public class AboutPetAdoptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
