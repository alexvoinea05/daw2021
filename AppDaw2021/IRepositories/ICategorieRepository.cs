using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
namespace AppDaw2021.IRepositories
{
    public interface ICategorieRepository
    {
        List<Categorie> GetAllCategories();
        Categorie FindById(string id);
        bool SaveChanges();
        void Create(Categorie entity);
        void Update(Categorie entity);
        void Delete(Categorie entity);
        Categorie FindByNume(string numeCategorie);
    }
}
