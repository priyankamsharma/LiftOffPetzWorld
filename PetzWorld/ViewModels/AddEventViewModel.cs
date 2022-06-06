using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace PetzWorld.ViewModels
{
    public class AddEventViewModel : Controller
    {
        [Required(ErrorMessage = "Event Name is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date is required!")]
        public DateTime dateTime { get; set; }

        public string Description { get; set; }

        public AddEventViewModel()
        { 
        }
    }
}
