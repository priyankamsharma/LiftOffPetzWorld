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
        public IActionResult AddDog(AddDogViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                Dog dog = new Dog
                {
                    Name = viewModel.Name,
                    Breed = viewModel.breed,
                    Weight = viewModel.weight,
                    Color = viewModel.color,
                    Sex = viewModel.sex,
                    Age = viewModel.age,
                    Info = viewModel.info,
                    Pic = viewModel.pic,
                };

                context.Dogs.Add(dog);
                context.SaveChanges();
                return Redirect("Index");
            }
            return View("Form", viewModel);
        }
        // I think we need context.Add and [something].SaveChange here? and also a for loop between line 43-49
    }
}