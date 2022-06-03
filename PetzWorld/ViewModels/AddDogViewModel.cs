using System.ComponentModel.DataAnnotations;
using PetzWorld.Models;


namespace PetzWorld.ViewModels
{
    public class AddDogViewModel
    {

        [Required(ErrorMessage = "Name is a required field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Breed needed")]

        public string breed { get; set; }
        public int weight { get; set; }
        public string color { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string info { get; set; }
        public string pic { get; set; }

        public AddDogViewModel()
        {
        }
    }

}