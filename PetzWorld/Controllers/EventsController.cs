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

        public IActionResult Form()
        {
            AddEventViewModel eventViewModel = new AddEventViewModel();
            return View(eventViewModel);
        }

        [HttpPost]
        public IActionResult AddEvent(AddEventViewModel ViewModel)
        {

            if (ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = ViewModel.Name,
                    Date = ViewModel.date,
                    Description = ViewModel.Description
                };

                context.Events.Add(newEvent);
                context.SaveChanges();
                return Redirect("Index");
            }
            return View("Form", ViewModel);
        }
    }
}

