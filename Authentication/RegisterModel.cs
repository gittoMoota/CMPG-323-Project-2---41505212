using System.ComponentModel.DataAnnotations;

namespace JWTAuthentication.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Username required!")]
        public string? Username { get; set; }


        [EmailAddress]
        [Required(ErrorMessage = "Email address required!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string? Password { get; set; }

    }
}
