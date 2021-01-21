using System;
using System.Collections.Generic;

#nullable disable

namespace AppDaw2021.Entities
{
    public partial class Review
    {
        public Review()
        {
            Cartes = new HashSet<Carte>();
        }

        public string IdReview { get; set; }
        public string Nota { get; set; }
        public string Comentariu { get; set; }
        public string IdUser { get; set; }
        public string IdCarte { get; set; }

        public virtual Carte IdCarteNavigation { get; set; }
        public virtual User IdUserNavigation { get; set; }
        public virtual ICollection<Carte> Cartes { get; set; }
    }
}
