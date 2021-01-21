using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;

namespace AppDaw2021.IServices
{
    public interface IReviewService
    {
        Review GetById(string id);
        List<Review> GetAll();
        Review GetByUserId(string id);
        Review GetByCarteId(string id);
    }
}
