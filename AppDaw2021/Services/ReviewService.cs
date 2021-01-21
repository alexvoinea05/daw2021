using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.IRepositories;
using AppDaw2021.Models;
using AppDaw2021.IServices;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using AppDaw2021.Mapper;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace AppDaw2021.Services
{
    public class ReviewService
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly AppSettings _appSettings;

        public ReviewService(IReviewRepository reviewRepository, IOptions<AppSettings> appSettings)
        {
            this._reviewRepository = reviewRepository;
            this._appSettings = appSettings.Value;
        }

        public List<Review> GetAll()
        {
            return _reviewRepository.GetAllReviews();
        }

        public Review GetById(string id)
        {
            return _reviewRepository.FindById(id);
        }

        public Review GetByIdCarte(String idCarte)
        {
            return _reviewRepository.FindByCarteId(idCarte);
        }

        public Review GetByIdUser(String idUser)
        {
            return _reviewRepository.FindByUserId(idUser);
        }

    }
}
