using System.Collections.Generic;
using System.Threading.Tasks;
using PortalApp.API.Helpers;
using PortalApp.API.Models;

namespace PortalApp.API.Data
{
    public interface IPortalRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<PagedList<User>> GetUsers(UserParams userParams);
         Task<User> GetUser(int id, bool isCurrentUser);
       
    }
}