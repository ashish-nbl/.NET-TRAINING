using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace TagHelpers.Models
{
    public class Student
    {
        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&#])[A-Za-z\\d@$!%*?&#]{8,}$",ErrorMessage ="password must contains at least one uppercase,one lowercase character,one number and one special symbol and minimum of 8 characters")]
        public string Password { get; set; } = string.Empty;

        [Required]
        [Compare("Password",ErrorMessage = "confirm password must match with password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required]
        [StringLength(15,MinimumLength=2,ErrorMessage ="name length must be between 2 to 15")]
        //[MinLength(2,ErrorMessage ="min length is 2 char")]
        //[MinLength(15, ErrorMessage = "max length is 15 char")]

        public string Name { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }
        [Required]

        public int Age { get; set; }
        [Required]

        public string Country { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage ="Invalid email format")]
        public string Email { get; set; } = string.Empty;
        [Required]

        public string Married { get; set; } = string.Empty;
        [Required]

        public bool RememberMe { get; set; }

        [RegularExpression("^(\\+91[\\-\\s]?)?[6-9]\\d{9}$",ErrorMessage ="Invalid mobile no")]
        public string MobileNo { get; set; }=string.Empty;

        [Required]
        [Url(ErrorMessage ="InvalidUrl")]
        public string SocialMedia { get; set; } = string.Empty;
    }

    public enum Gender
    {
        male,female
    }
}
