using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace PetzWorld.ViewModels
{
    public class AddEventViewModel : Controller
    {
        [Required(ErrorMessage = "Event Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date and Time for Event is required!")]
        public DateTime DateTime { get; set; }

        public string Description { get; set; }
    
        public AddEventViewModel()
        { 
        }
    }
}
