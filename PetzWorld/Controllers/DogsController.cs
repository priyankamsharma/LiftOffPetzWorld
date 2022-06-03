using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using PetzWorld.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PetzWorld.Controllers
{
    public class DogsController : Controller
    {
        private ApplicationDbContext context;

        public DogsController(ApplicationDbContext dogDbContext)
        {
            context = dogDbContext;
        }

        public IActionResult Index()
        {
            List<Dog> dogs = context.Dogs.ToList();
            return View(dogs);
        }
        
        public IActionResult Form()
        {
            AddDogViewModel viewModel = new AddDogViewModel();
            return View(viewModel);
            //return View();
        }

        [HttpPost]
        public IActionResult AddDog(AddDogViewModel viewModel)
        {

            if (!ModelState.IsValid)
            {
                return View("Form", viewModel);
            }

            return Redirect("Index");
        }

    }
}