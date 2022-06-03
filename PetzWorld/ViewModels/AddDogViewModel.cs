using System.ComponentModel.DataAnnotations;

namespace PetzWorld.ViewModels
{
    public class AddDogViewModel
    {

        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Breed needed")]
        public string breed { get; set; }
        public int age { get; set; }
    }
}