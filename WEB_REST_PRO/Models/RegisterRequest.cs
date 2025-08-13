using System.ComponentModel.DataAnnotations;

namespace WEB_REST_PRO.Models
{
    public class RegisterRequest
    {
        [Required]
        [MinLength(2)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [MinLength(2)]
        public string Sobrenome { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}
