using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Models;
using AppDaw2021.Entities;

namespace AppDaw2021.Mapper
{
    public class ReviewMapper
    {
        public static Review ToReview(ReviewResponse request)
        {
            return new Review
            {
                IdReview = request.idReview,
                Nota = request.nota,
                IdCarte = request.idCarte,
                IdUser = request.idUser,
                Comentariu = request.comentariu
            };
        }

        public static ReviewResponse ToReviewResponse(Review request)
        {
            return new ReviewResponse
            {
                idUser = request.IdUser,
                idCarte = request.IdCarte,
                idReview = request.IdReview,
                nota = request.Nota,
                comentariu = request.Comentariu
            };
        }
    }
}
