using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.Models;

namespace AppDaw2021.IServices
{
    public interface IAutorService
    {
        Autor GetById(string id);
        List<Autor> GetAll();
        Autor GetByNume(string nume);
    }
}
