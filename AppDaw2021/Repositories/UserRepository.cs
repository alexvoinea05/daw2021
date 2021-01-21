using AppDaw2021.Entities;
using AppDaw2021.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDaw2021.Repositories
{
    public class UserRepository : IUserRepository
    {
        protected readonly proiectDawContext _context;
        protected readonly DbSet<User> _table;



        public UserRepository(proiectDawContext context)
        {
            _context = context;
            _table = context.Set<User>();
        }

        public void Create(User entity)
        {
            _context.Set<User>().Add(entity);
        }

        public void Delete(User entity)
        {
            _table.Remove(entity);
        }

        public User FindById(string id)
        {
            return _context.Users.SingleOrDefault(x => x.IdUser == id) ;
        }

        public List<User> GetAllUsers()
        {
            return _table.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public void Update(User entity)
        {
            _table.Update(entity);
        }

        public User GetByUserAndPassword(string username, string password)
        {
            return _table.Where(x => x.Username == username && x.Parola == password).FirstOrDefault();
        }
    }
}
