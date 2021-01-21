using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;
namespace AppDaw2021.IServices
{
    public interface IUserService
    {
        User GetById(string id);
        List<User> GetAll();
        bool Register(AuthenticationRequest request, string nume, string prenume, string email);
        AuthenticationResponse Login(AuthenticationRequest request);
    }
}

