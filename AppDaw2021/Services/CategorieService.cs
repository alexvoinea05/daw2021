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
    public class CategorieService : ICategorieService
    {
        private readonly ICategorieRepository _categorieRepository;
        private readonly AppSettings _appSettings;

        public CategorieService(ICategorieRepository categorieRepository, IOptions<AppSettings> appSettings)
        {
            this._categorieRepository = categorieRepository;
            this._appSettings = appSettings.Value;
        }

        public List<Categorie> GetAll()
        {
            return _categorieRepository.GetAllCategories();
        }

        public Categorie GetById(string id)
        {
            return _categorieRepository.FindById(id);
        }

        public Categorie GetByNume(String nume)
        {
            return _categorieRepository.FindByNume(nume);
        }

    }
}
