using System.ComponentModel.DataAnnotations;

namespace CODEFIRST.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]

        public string Email { get; set; } = string.Empty;
        [Required]

        public int Age { get; set; }
    }
}
