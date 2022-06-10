using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using PetzWorld.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace PetzWorld.Controllers
{
    [Authorize]
    public class FavouritesController : Controller
    {
        private ApplicationDbContext context;

        public FavouritesController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            List<Favourite> favourites = context.Favorites
                                            .Where(f => f.ApplicationUserId == currentUserId)
                                            .ToList();

            List<Dog> FavDogs = new List<Dog>();

            foreach (var fav in favourites)
            {
                Dog favDog = context.Dogs.Find(fav.DogId);

                FavDogs.Add(favDog);

            }
            return View(FavDogs);    
        }

        public IActionResult AddFav()
        {
            AddFavouriteViewModel favViewModel = new AddFavouriteViewModel();
            return View(favViewModel);
        }

        [HttpPost]
        public IActionResult AddFav(AddFavouriteViewModel addFavouriteViewModel)
        {

            if (ModelState.IsValid)
            {
                string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                Favourite newFav = new Favourite
                {
                    DogId = addFavouriteViewModel.DogId,
                    Dog = context.Dogs.Find(addFavouriteViewModel.DogId),
                    //ApplicationUser = User,
                    ApplicationUserId = currentUserId
                };

                context.Favorites.Add(newFav);
                context.SaveChanges();
                return Redirect("/Favourites");
            }
            return View("Search/Results", addFavouriteViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.favourites = context.Favorites.ToList();
            return View();
        }

        [HttpPost("/Favourites/Delete")]
        public IActionResult Delete(int[] favIds)
        {
            foreach (int favId in favIds)
            {
                Favourite theFav = context.Favorites.Find(favId);
                context.Favorites.Remove(theFav);
            }
            context.SaveChanges();
            
            return Redirect("/Favourites");
        }
    }
}

