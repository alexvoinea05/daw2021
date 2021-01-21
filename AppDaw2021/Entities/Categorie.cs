using System;
using System.Collections.Generic;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class Categorie
    {
        public Categorie()
        {
            Cartes = new HashSet<Carte>();
        }

        public string IdCategorie { get; set; }
        public string GenCategorie { get; set; }

        public virtual ICollection<Carte> Cartes { get; set; }
    }
}
