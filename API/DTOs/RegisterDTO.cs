using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email should be in a proper format")]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}
