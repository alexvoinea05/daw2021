using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using AppDaw2021.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AppDaw2021.Repositories
{
    public class CarteRepository : ICarteRepository
    {
        protected readonly proiectDawContext _context;
        protected readonly DbSet<Carte> _table;



        public CarteRepository(proiectDawContext context)
        {
            _context = context;
            _table = context.Set<Carte>();
        }

        public void Create(Carte entity)
        {
            _context.Set<Carte>().Add(entity);
        }

        public void Delete(Carte entity)
        {
            _table.Remove(entity);
        }

        public Carte FindById(string id)
        {
            return _table.Find(id);
        }

        public List<Carte> GetAllCarti()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(Carte entity)
        {
            _table.Update(entity);
        }

        public Carte FindByNumeCarte(string nume)
        {
            return _table.Where(x => x.NumeCarte == nume).FirstOrDefault();
        }

        public Carte FindByIdAutor(string idAutor)
        {
            return _table.Where(x => x.IdAutor == idAutor).FirstOrDefault();
        }

        public List<Carte> FindByCategorie(string categorie)
        {
            return _table.Where(x => x.IdCategorie == categorie).ToList();
        }
    }
}
