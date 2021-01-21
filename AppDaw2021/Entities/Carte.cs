using System;
using System.Collections.Generic;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class Carte
    {
        public Carte()
        {
            Reviews = new HashSet<Review>();
        }

        public string IdCarte { get; set; }
        public string NumeCarte { get; set; }
        public string IdAutor { get; set; }
        public string Descriere { get; set; }
        public string IdReview { get; set; }
        public string IdCategorie { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Categorie IdCategorieNavigation { get; set; }
        public virtual Review IdReviewNavigation { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
