using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using System.Collections.Generic;
using System.Linq;

namespace DogzThing.Controllers
{
    public class DogDataController : Controller
    {
        private ApplicationDbContext context;

        public DogDataController(ApplicationDbContext DbContext)
        {
            context = DbContext;
        }

        public IActionResult Index()
        {
            List<DogData> DogData = context.DogDataSets.ToList();
            return View(DogData);
        }

        public IActionResult Form()
        {
            // AddDogDataViewModel
            return View();
        }
    }
}

