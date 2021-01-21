using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;
namespace AppDaw2021.IServices
{
    public interface ICategorieService
    {
        Categorie GetById(string id);
        List<Categorie> GetAll();
        Categorie GetByNume(string nume);
    }
}
