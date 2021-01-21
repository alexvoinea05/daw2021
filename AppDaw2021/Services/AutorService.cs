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
    public class AutorService
    {
        private readonly IAutorRepository _autorRepository;
        private readonly AppSettings _appSettings;

        public AutorService(IAutorRepository autorRepository, IOptions<AppSettings> appSettings)
        {
            this._autorRepository = autorRepository;
            this._appSettings = appSettings.Value;
        }

        public List<Autor> GetAll()
        {
            return _autorRepository.GetAllAutori();
        }

        public Autor GetById(string id)
        {
            return _autorRepository.FindById(id);
        }

        public Autor GetByNume(String nume)
        {
            return _autorRepository.FindByNume(nume);
        }

    }
}
