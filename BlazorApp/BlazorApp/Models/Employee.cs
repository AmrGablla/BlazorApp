using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Models
{
    public class Employee
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
