using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace circle3innovationlab.Models
{
    public class ContactFormViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Phone number is required")]
        [RegularExpression(@"^\+?[1-9][0-9]{9,14}$", ErrorMessage = "Please enter a valid international phone number.")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }

     
        public string? Message { get; set; }

    }

}
