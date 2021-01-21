using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;

namespace AppDaw2021.Mapper
{
    public class CategorieMapper
    {
        public static Categorie ToAutor(CategorieResponse request)
        {
            return new Categorie
            {
                IdCategorie = request.idCategorie,
                GenCategorie = request.numeCategorie,
            };
        }

        public static CategorieResponse ToCategorieResponse(Categorie request)
        {
            return new CategorieResponse
            {
                idCategorie = request.IdCategorie,
                numeCategorie = request.GenCategorie,
            };
        }
    }
}
