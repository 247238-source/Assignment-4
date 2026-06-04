using System.ComponentModel.DataAnnotations;

namespace task2.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "First name is mandatory.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is mandatory.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email address is mandatory.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email format.")]
        public string Email { get; set; } = string.Empty;
    }
}