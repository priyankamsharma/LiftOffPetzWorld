using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
