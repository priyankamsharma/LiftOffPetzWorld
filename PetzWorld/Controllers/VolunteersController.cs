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
    public class VolunteersController : Controller
    {
        private ApplicationDbContext context;

        public VolunteersController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewBag.currentUserName = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Volunteer> newVolunteer = context.Volunteers.ToList();
            return View(newVolunteer);
        }

        [HttpPost]
        public IActionResult Add(AddVolunteerViewModel addVolunteerViewModel)
        {
            if (ModelState.IsValid)
            {
                Volunteer newVolunteer = new Volunteer
                {
                    EventId = addVolunteerViewModel.EventId,
                    EventName= addVolunteerViewModel.EventName,
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
