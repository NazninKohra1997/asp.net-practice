using System.ComponentModel.DataAnnotations;

namespace Html_tag_helper.Models
{
    public class Helper
    {
        [Required,Display(Name = "EmailAddress")]
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }
    }
}
