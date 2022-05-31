using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
