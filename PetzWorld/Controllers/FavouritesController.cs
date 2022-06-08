﻿using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using PetzWorld.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Claims;

namespace PetzWorld.Controllers
{
    public class FavouritesController : Controller
    {
        private ApplicationDbContext context;

        public FavouritesController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.userName = this.User.FindFirstValue(ClaimTypes.Name);
            List<Favourite> Favourites = context.Favorites.ToList();
            return View(Favourites);    
        }

        public IActionResult Add()
        {
            AddFavouriteViewModel favViewModel = new AddFavouriteViewModel();
            return View(favViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddFavouriteViewModel addFavouriteViewModel)
        {
            if (ModelState.IsValid)
            {
                Favourite newFav = new Favourite
                {
                    DogId = addFavouriteViewModel.DogId,
                    Name = addFavouriteViewModel.Name,
                    ApplicationUser = addFavouriteViewModel.ApplicationUser,
                    ApplicationUserId = addFavouriteViewModel.ApplicationUserId
                };

                context.Favorites.Add(newFav);
                context.SaveChanges();
                return Redirect("/Favourites");
            }
            return View(addFavouriteViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.favourites = context.Favorites.ToList();
            return View();
        }

        [HttpPost]
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

