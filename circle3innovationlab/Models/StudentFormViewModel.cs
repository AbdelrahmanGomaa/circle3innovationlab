using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace circle3innovationlab.Models
{
    public class StudentFormViewModel
    {
        [Required(ErrorMessage = "Student Name is required")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\+?[1-9][0-9]{9,14}$", ErrorMessage = "Please enter a valid international phone number.")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        public string? College { get; set; } // Not Required

        [Required(ErrorMessage = "Please select a course")]
        public string ChooseCourse { get; set; }

        public string? CourseType { get; set; } // Not Required
    }





}


