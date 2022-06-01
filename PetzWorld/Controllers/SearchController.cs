using Microsoft.AspNetCore.Mvc;
using PetzWorld.Data;
using PetzWorld.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PetzWorld.ViewModels;

namespace PetzWorld.Controllers
{
    public class SearchController : Controller
    {
        internal static Dictionary<string, string> ColumnChoices = new Dictionary<string, string>()
        {
            {"dogs", "Dogs"},
            {"cats", "Cats"}
        };

        private ApplicationDbContext context;

        public SearchController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.columns = ColumnChoices;
            ViewBag.dogs = context.Dogs.ToList();
            //ViewBag.cats = context.Cats.ToList();
            return View();
        }
        //[HttpPost("/search/results")]
        //public IActionResult Results(string searchType)
        //{ 
        //    //ViewBag.searchType = searchType;
            
        
        //    //if (searchType == "dogs")
        //    //{
        //    //    List<Dogs> dogs = context.Dogs.ToList();

        //    //    return View(dogs);
        //    //}
        //}
    }
}
