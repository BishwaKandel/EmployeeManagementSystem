using System.ComponentModel.DataAnnotations;

namespace EmployeeMS.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; } 
    }
}
