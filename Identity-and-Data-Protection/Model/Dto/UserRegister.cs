using System.ComponentModel.DataAnnotations;

namespace Identity_and_Data_Protection.Model.Dto
{
    public class UserRegister
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(6)]
        public string Password { get; set; }
    }
}
