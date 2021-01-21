using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
namespace AppDaw2021.IRepositories
{
    public interface ICarteRepository
    {
        List<Carte> GetAllCarti();
        Carte FindById(string id);
        bool SaveChanges();
        void Create(Carte entity);
        void Update(Carte entity);
        void Delete(Carte entity);
        Carte FindByNumeCarte(string nume);
        Carte FindByIdAutor(string idAutor);
        List<Carte> FindByCategorie(string idCategorie);
    }
}
