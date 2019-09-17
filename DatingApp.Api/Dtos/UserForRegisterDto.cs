using System.ComponentModel.DataAnnotations;

namespace DatingApp.Api.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You must specify a username between 4 and 12 characters")]
        public string Username { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 30 characters")]
        public string Password { get; set; }
    }
}