using System.ComponentModel.DataAnnotations;

namespace GroceryAtYourDoor.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
