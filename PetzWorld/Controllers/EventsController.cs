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
    public class EventsController : Controller
    {
        private ApplicationDbContext context;

        public EventsController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Event> newEvents = context.Events.ToList();
            return View(newEvents);
        }

        public IActionResult Add()
        {
            AddEventViewModel eventViewModel = new AddEventViewModel();
            return View(eventViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEventViewModel addEventViewModel)
        {
            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    EventDate = addEventViewModel.EventDate,
                    Description = addEventViewModel.Description
                };

                context.Events.Add(newEvent);
                context.SaveChanges();
                return Redirect("/Events");
            }
            return View(addEventViewModel);
        }

        [HttpGet("/events/{id}/edit")]
        public IActionResult EditDescription(int id)
        {
            ViewBag.selectedAnimal = ApplicationDbContext.GetById(id);

            ViewBag.description = $"{ApplicationDbContext.GetById(id).Description}'s";

            return View();
        }

        [HttpPost("events/{id}/edit")]
        public IActionResult NewDescription(int id, string description)
        {
            ApplicationDbContext.ChangeDescription(id, description);

            return Redirect("/events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = context.Events.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach (int eventId in eventIds)
            {
                Event theEvent = context.Events.Find(eventId);
                context.Events.Remove(theEvent);
            }
            context.SaveChanges();

            return Redirect("/Events");
        }
    }
}

//// GET: "/animals/edit/{id}"
//[HttpGet("/animals/{id}/editname")]
//public IActionResult EditName(int id)
//{
//    ViewBag.selectedAnimal = AnimalData.GetById(id);

//    ViewBag.name = $"{AnimalData.GetById(id).Name}'s";

//    return View();
//}
