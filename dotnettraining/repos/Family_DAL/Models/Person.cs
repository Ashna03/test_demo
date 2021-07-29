using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_DAL.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Display(Name = "Date-of-Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "User Email")]
        public string UserEmail { get; set; }
        public bool IsDeleted { get; set; }
    }
}
