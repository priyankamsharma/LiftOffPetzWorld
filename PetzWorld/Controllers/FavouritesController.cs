using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using PetzWorld.ViewModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

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
            List<Favourite> Favourites = context.Favorites.ToList();
            return View(Favourites);    
        }
    }
}

