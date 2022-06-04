using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.Controllers
{
    [Authorize]
    public class FavouriteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
