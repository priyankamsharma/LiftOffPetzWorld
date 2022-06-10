using PetzWorld.Models;
using System.ComponentModel.DataAnnotations;

namespace PetzWorld.ViewModels
{
    public class AddFavouriteViewModel
    {
        [Required]
        public int DogId { get; set; }

        public AddFavouriteViewModel() 
        { 
        }
    }
}

