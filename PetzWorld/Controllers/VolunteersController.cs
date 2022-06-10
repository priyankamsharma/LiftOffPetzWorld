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
    public class VolunteersController : Controller
    {
        private ApplicationDbContext context;

        public VolunteersController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {

            List<Event> newEvents = context.Events.ToList();
            return View(newEvents);
        }

        [HttpPost]
        public IActionResult Add(AddVolunteerViewModel addVolunteerViewModel)
        {
            if (ModelState.IsValid)
            {
                Volunteer newVolunteer = new Volunteer
                {
                    EventId = addVolunteerViewModel.EventId,
                    EventName = addVolunteerViewModel.EventName,
                    Description = addVolunteerViewModel.Description
                };

                context.Volunteers.Add(newVolunteer);
                context.SaveChanges();
                return Redirect("/Volunteers");
            }
            return View(addVolunteerViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.volunteers = context.Volunteers.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] volunteerIds)
        {
            foreach (int volunteerId in volunteerIds)
            {
                Volunteer theVolunteer = context.Volunteers.Find(volunteerId);
                context.Volunteers.Remove(theVolunteer);
            }
            context.SaveChanges();

            return Redirect("/Volunteers");
        }
    }
}
