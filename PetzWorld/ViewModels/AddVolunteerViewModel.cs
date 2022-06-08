using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetzWorld.Models;

namespace PetzWorld.ViewModels
{
    public class AddVolunteerViewModel
    {
        public int EventId { get; set; }
        [Required(ErrorMessage = "Event Name is required!")]
        public string EventName { get; set; }
        public string Description { get; set; }
        public string ApplicationUserId { get; set; }

        public AddVolunteerViewModel()
        {
        }
    }
}
