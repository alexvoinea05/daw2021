using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
namespace AppDaw2021.IRepositories
{
    public interface IReviewRepository
    {
        List<Review> GetAllReviews();
        Review FindById(string id);
        bool SaveChanges();
        void Create(Review entity);
        void Update(Review entity);
        void Delete(Review entity);
        Review FindByUserId(string id);
        Review FindByCarteId(string idCarte);

    }

}
