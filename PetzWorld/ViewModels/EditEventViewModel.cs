using Microsoft.AspNetCore.Mvc;

namespace PetzWorld.ViewModels
{
    public class EditEventViewModel : AddEventViewModel
    {
        public string Id { get; set;}
        public string Description { get; set; }

    }
}
