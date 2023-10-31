using System.ComponentModel.DataAnnotations;

namespace Client_Server_side_validation.Models
{
    public class Form
    {
        [Required,EmailAddress,Display(Name = "EmailAddress")]
       // [RegularExpression("@gmail.com",ErrorMessage = "This email is not valid")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
