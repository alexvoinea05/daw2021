using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
namespace AppDaw2021.IRepositories
{
    public interface IAutorRepository
    {
        List<Autor> GetAllAutori();
        Autor FindById(string id);
        bool SaveChanges();
        void Create(Autor entity);
        void Update(Autor entity);
        void Delete(Autor entity);
        Autor FindByNume(string nume);
    }
}
