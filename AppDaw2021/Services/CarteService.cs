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
    public class CarteService : ICarteService
    {
        private readonly ICarteRepository _carteRepostiory;
        private readonly AppSettings _appSettings;

        public CarteService(ICarteRepository carteRepository, IOptions<AppSettings> appSettings)
        {
            this._carteRepostiory = carteRepository;
            this._appSettings = appSettings.Value;
        }

        public List<Carte> GetAll()
        {
            return _carteRepostiory.GetAllCarti();
        }

        public Carte GetByCarteId(string id)
        {
            return _carteRepostiory.FindById(id);
        }

        public Carte GetByNume(String nume)
        {
            return _carteRepostiory.FindByNumeCarte(nume);
        }

        public Carte GetByAutorId(string id)
        {
            return _carteRepostiory.FindByIdAutor(id);
        }

        public List<Carte> GetByCategorie(string categorie)
        {
            return _carteRepostiory.FindByCategorie(categorie);
        }





    }
}
