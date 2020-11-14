using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp_API.Helpers;
using DatingApp_API.Models;

namespace DatingApp_API.Data
{
    public interface IDatingRepo
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<PagedList<User>> GetUsers(UserParams userParams);

        Task<User> GetUser(int id);

        Task<Photo> GetPhoto(int id);
        
        Task<Photo> GetMainPhotoForUser(int userID);
    }
}