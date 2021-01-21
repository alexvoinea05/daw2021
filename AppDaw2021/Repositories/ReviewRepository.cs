using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
using Microsoft.EntityFrameworkCore;
using AppDaw2021.IRepositories;

namespace AppDaw2021.Repositories
{
    public class ReviewRepository : IReviewRepository
    {
       
        protected readonly proiectDawContext _context;
        protected readonly DbSet<Review> _table;



        public ReviewRepository(proiectDawContext context)
        {
            _context = context;
            _table = context.Set<Review>();
        }

        public void Create(Review entity)
        {
            _context.Set<Review>().Add(entity);
        }

        public void Delete(Review entity)
        {
            _table.Remove(entity);
        }

        public Review FindById(string id)
        {
            return _table.Find(id);
        }

        public List<Review> GetAllReviews()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(Review entity)
        {
            _table.Update(entity);
        }

        public Review FindByUserId(string idUser)
        {
            return _table.Where(x => x.IdUser == idUser).FirstOrDefault();
        }

        public Review FindByCarteId(string idCarte)
        {
            return _table.Where(x => x.IdCarte == idCarte).FirstOrDefault();
        }




    }

}
