using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDTO
    {

        [Required]
        public string Username {get;set;}

        [Required]  // Specify requirements = Can use Regular expressions
        public string Password {get;set;}
    }
}