using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp
{
    public class User
    {
       
        public int Id { get; set; }

        [Display(Name = "Vorname")]
        public string FirstName { get; set; }

        [Display(Name = "Nachname")]
        [Required(ErrorMessage = "Nachname ist notwendig")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Der Nachname kann nicht weniger als 3 oder mehr  als 30 Zeichen haben")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "E-Mail ist notwendig")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
