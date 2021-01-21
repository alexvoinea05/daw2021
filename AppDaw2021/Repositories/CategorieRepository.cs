using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.IRepositories;
using AppDaw2021.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppDaw2021.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        protected readonly proiectDawContext _context;
        protected readonly DbSet<Categorie> _table;



        public CategorieRepository(proiectDawContext context)
        {
            _context = context;
            _table = context.Set<Categorie>();
        }

        public void Create(Categorie entity)
        {
            _context.Set<Categorie>().Add(entity);
        }

        public void Delete(Categorie entity)
        {
            _table.Remove(entity);
        }

        public Categorie FindById(string id)
        {
            return _table.Find(id);
        }

        public List<Categorie> GetAllCategories()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(Categorie entity)
        {
            _table.Update(entity);
        }

        public Categorie FindByNume(string nume)
        {
            return _table.Where(x => x.GenCategorie == nume).First();
        }


    }
}
