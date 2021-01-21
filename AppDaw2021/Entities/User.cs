using System;
using System.Collections.Generic;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class User
    {
        public User()
        {
            Reviews = new HashSet<Review>();
        }

        public string IdUser { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; }
        public string Username { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
