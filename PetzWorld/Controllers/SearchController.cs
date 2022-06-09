using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PetzWorld.ViewModels;
using System.Security.Claims;

namespace PetzWorld.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext context;

        public SearchController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Dog> dogs = context.Dogs.ToList();

            return View(dogs);
        }

        public IActionResult FavAdd()
        {
            AddFavouriteViewModel favViewModel = new AddFavouriteViewModel();
            return View(favViewModel);
        }

        [HttpPost("/Favourites/Add")]
        public IActionResult FavAdd(AddFavouriteViewModel addFavouriteViewModel)
        {
            if (ModelState.IsValid)
            {
                Favourite newFav = new Favourite
                {
                    DogId = addFavouriteViewModel.DogId,
                    Name = addFavouriteViewModel.Name,
                    ApplicationUserId = addFavouriteViewModel.ApplicationUserId,
                    ApplicationUser = addFavouriteViewModel.ApplicationUser
                };

                context.Favorites.Add(newFav);
                context.SaveChanges();
                return Redirect("/Favourites");
            }
            return View(addFavouriteViewModel);
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dog> displayDogs = new List<Dog>();

            if (searchType == "dogs" || searchType == "Dogs")
            {
                if (searchTerm == "all")
                {
                    displayDogs = context.Dogs.ToList();
                }
                else
                {
                    displayDogs = context.Dogs
                        .Where(j => j.Breed == searchTerm)
                        .ToList();
                }
            }

            ViewBag.displayDogs = displayDogs;
            ViewBag.title = "Searched " + searchType + " : " + searchTerm;
            return View("Results");
        }
    }
}