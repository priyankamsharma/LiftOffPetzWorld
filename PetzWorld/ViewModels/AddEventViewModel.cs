using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetzWorld.Models;

namespace PetzWorld.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Event Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date/Time must be selected")]
        public DateTime EventDate { get; set; }
        public string Description { get; set; }
    
        public AddEventViewModel()
        { 
        }
    }
}
