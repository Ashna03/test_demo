using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApis
{
    public class Post
    {
        [Required(ErrorMessage = "UserId is a mandatory field")]
        public int? userid { get; set; }

        [Key]
        [Range(1,10, ErrorMessage = "Please enter a value in the range 1 - 10")]
        public int id { get; set; }

        [StringLength(100, ErrorMessage = "The expected string length is upto 100")]
        public string title { get; set; }

        [MinLength(10, ErrorMessage = "The length of text should be greater than 10 characters")]
        public string body { get; set; }
        
        [EmailAddress(ErrorMessage = "Invalid email format. Eg: someone@yourcompany.com")]
        public string Email { get; set; }
    }
}
