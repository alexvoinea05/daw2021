using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;

namespace AppDaw2021.IServices
{
    public interface ICarteService
    {
        List<Carte> GetAll();
        Carte GetByCarteId(string id);
        List<Carte> GetByCategorie(string categorie);
        Carte GetByNume(string nume);

    }
}
