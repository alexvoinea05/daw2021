using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Models;
using AppDaw2021.Entities;

namespace AppDaw2021.Mapper
{
    public class CarteMapper
    {
        public static Carte ToCarte(CarteResponse request)
        {
            return new Carte
            {
                IdCarte = request.idCarte,
                NumeCarte = request.numeCarte,
                IdAutor = request.idAutor,
                IdCategorie = request.idCategorie,
                IdReview = request.idReview,
                Descriere = request.descriere

            };
        }

        public static CarteResponse ToCarteResponse(Carte request)
        {
            return new CarteResponse
            {
                idCarte = request.IdCarte,
                numeCarte = request.NumeCarte,
                idReview = request.IdReview,
                idAutor = request.IdAutor,
                idCategorie = request.IdCategorie,
                descriere = request.Descriere
            };
        }
    }
}
