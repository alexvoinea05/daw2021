using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;
namespace AppDaw2021.Mapper
{
    public static class UserMapper
    {
        public static User ToUser(AuthenticationRequest request)
        {
            return new User
            {
                Username = request.Username,
                Parola = request.Password,
            };
        }

        public static User ToUserExtension(this AuthenticationRequest request, string nume, string prenume, string email )
        {
            return new User
            {
                Username = request.Username,
                Parola = request.Password,
                Nume = nume,
                Prenume = prenume,
                Email = email
            };
        }
    }
}
