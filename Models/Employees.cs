using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SongebobFanClub.Models
{
    public class Employees
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage ="Please enter your first name using 30 characters or less.")]
        [Column("First Name")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        public string? FirstName { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "Please enter your last name using 30 characters or less.")]
        [Column("Last Name")]
        public string? LastName { get; set; }


        [Required]
        [StringLength(20, ErrorMessage = "Please enter your position at work using 20 characters or less.")]
        public string? Position { get; set; }


        [Required]
        [StringLength(10, ErrorMessage = "Please enter your salary using 10 characters or less.")]
        public string? Salary { get; set; }


        [Required]
        [Range(17,90)]
        public int Age { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string? Email { get; set; }
    }
}
