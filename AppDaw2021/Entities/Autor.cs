using System;
using System.Collections.Generic;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class Autor
    {
        public Autor()
        {
            Cartes = new HashSet<Carte>();
        }

        public string IdAutor { get; set; }
        public string NumeAutor { get; set; }

        public virtual ICollection<Carte> Cartes { get; set; }
    }
}
