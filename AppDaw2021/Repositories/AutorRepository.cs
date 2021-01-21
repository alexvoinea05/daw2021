using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppDaw2021.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        protected readonly proiectDawContext _context;
        protected readonly DbSet<Autor> _table;



        public AutorRepository(proiectDawContext context)
        {
            _context = context;
            _table = context.Set<Autor>();
        }

        public void Create(Autor entity)
        {
            _context.Set<Autor>().Add(entity);
        }

        public void Delete(Autor entity)
        {
            _table.Remove(entity);
        }

        public Autor FindById(string id)
        {
            return _table.Find(id);
        }

        public List<Autor> GetAllAutori()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(Autor entity)
        {
            _table.Update(entity);
        }

        public Autor FindByNume(string nume)
        {
            return _table.Where(x => x.NumeAutor == nume).FirstOrDefault();
        }
    }
}
