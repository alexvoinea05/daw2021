using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDaw2021.Entities;
namespace AppDaw2021.IRepositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        User FindById(string id);
        bool SaveChanges();
        void Create(User entity);
        void Update(User entity);
        void Delete(User entity);
        User GetByUserAndPassword(string username, string password);
    }
}
