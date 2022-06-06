using PetzWorld.Models;

namespace PetzWorld.ViewModels
{
    public class AddFavouriteViewModel
    {
        public int Id { get; set; }
        public int DogId { get; set; }
        public string Name { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        public AddFavouriteViewModel() 
        { 
        }
    }
}

