using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactTask.Shared.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "last is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        //[Range(10, 11, ErrorMessage = "Age must be between 10 and 11")]
        public string PhoneNumber { get; set; }

    }
}
