using Microsoft.AspNetCore.Mvc;
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
    }
}

