using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; } 
        public DateTime CreatedDate { get; set; }
        public string FirstName { get; set; } 
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
