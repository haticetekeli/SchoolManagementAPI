using System.ComponentModel.DataAnnotations;
using SchoolManagementAPI.Services.Teacher;

namespace SchoolManagementAPI.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
} 