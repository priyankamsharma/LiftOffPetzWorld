using System.ComponentModel.DataAnnotations;

namespace PetzWorld.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
