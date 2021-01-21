using AppDaw2021.Entities;
using AppDaw2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDaw2021.Mapper
{
    public class AutorMapper
    {
        public static Autor ToAutor(AutorResponse request)
        {
            return new Autor
            {
                IdAutor = request.Id,
                NumeAutor = request.Nume,
            };
        }

        public static AutorResponse ToAutorResponse(Autor request)
        {
            return new AutorResponse
            {
                Id = request.IdAutor,
                Nume = request.NumeAutor,
            };
        }
    }
}
