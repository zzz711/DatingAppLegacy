using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp_API.Helpers;
using DatingApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp_API.Data
{
    public class DatingRepo : IDatingRepo
    {
        private readonly DataContext context;

        public DatingRepo(DataContext context)
        {
            this.context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }

        public async Task<Photo> GetMainPhotoForUser(int userID)
        {
            return await context.Photos.Where( u => u.UserId == userID).FirstOrDefaultAsync(p => p.IsMain);
        }

        public async Task<Photo> GetPhoto(int id)
        {
            var photo = await context.Photos.FirstOrDefaultAsync(p => p.Id == id);

            return photo;
        }

        public async Task<User> GetUser(int id)
        {
            var user = await context.Users.Include( p => p.Photos).FirstOrDefaultAsync(u => u.Id == id);

            return user;
        }

        public async Task<PagedList<User>> GetUsers(UserParams userParams)
        {
            var users = context.Users.Include(p => p.Photos);

            return await PagedList<User>.CreateAsync(users, userParams.PageNumber, userParams.PageSize);
        }

        public async Task<bool> SaveAll()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}