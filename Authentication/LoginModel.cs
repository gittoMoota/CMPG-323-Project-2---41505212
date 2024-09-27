using System.ComponentModel.DataAnnotations;

namespace _41505212__API.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username required!")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; set; }

    }
}
