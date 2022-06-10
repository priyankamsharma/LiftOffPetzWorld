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
    public class DogsController : Controller
    {
        private ApplicationDbContext context;

        public DogsController(ApplicationDbContext dogDbContext)
        {
            context = dogDbContext;
        }

        public IActionResult Index()
        {
            List<Dog> dogs = context.Dogs.ToList();
            return View(dogs);
        }

        public IActionResult Form()
        {
            AddDogViewModel viewModel = new AddDogViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddDog(AddDogViewModel addDogViewModel)
        {

            if (ModelState.IsValid)
            {
                Dog dog = new Dog
                {
                    Name = addDogViewModel.Name,
                    Breed = addDogViewModel.breed,
                    Weight = addDogViewModel.weight,
                    Color = addDogViewModel.color,
                    Sex = addDogViewModel.sex,
                    Age = addDogViewModel.age,
                    Info = addDogViewModel.info,
                    Pic = addDogViewModel.pic,
                };

                context.Dogs.Add(dog);
                context.SaveChanges();
                return Redirect("Index");
            }
            return View("Form", addDogViewModel);
        }

        //// GET: "/dogs/edit/{id}"
        //[HttpGet("/Dogs/EditInfo")]
        //public IActionResult EditInfo(int[] dogIds)
        //{
        //    ViewBag.selectedDog = context.Dogs.Find(dogIds);
        //    ViewBag.info = $"{context.Dogs.Find(dogIds).Info}'s";

        //    return View();
        //}

        //[HttpPost("Dogs/EditInfo")]
        //public IActionResult NewInfo(int dogId, string info)
        //{
        //    //context.Dogs.ChangeInfo(dogId, info);
        //    ApplicationDbContext.ChangeInfo(dogId, info);
        //    return Redirect("/Dogs");
        //}

        public IActionResult Delete()
        {
            ViewBag.dogs = context.Dogs.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] dogIds)
        {
            foreach (int dogId in dogIds)
            {
                Dog theDog = context.Dogs.Find(dogId);
                context.Dogs.Remove(theDog);
            }
            context.SaveChanges();

            return Redirect("/Dogs");
        }
    }
}