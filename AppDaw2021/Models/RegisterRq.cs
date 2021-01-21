using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace AppDaw2021.Models
{
    public class RegisterRq
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string idUser { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string nume { get; set; }
        [Required]
        public string prenume { get; set; }
    }
}
