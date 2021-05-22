using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.User
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _databaseContext ;
        public UserRepository(ApplicationContext applicationContext)
        {
            _databaseContext = applicationContext;
        }
        public async Task<List<Models.Project>> GetProjects(Models.User user)
        {
            var projects =  _databaseContext.Projects.
                    Include(s => s.Users).Include(d=>d.Columns).
                    Where(p => p.Users.Any(u => user.Nickname == u.Nickname)).
                    Select(p => new Models.Project()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Title = p.Title,
                    
                });
                var result = await projects.ToListAsync();
                return result;
        }
        public async Task<Models.User> GetUserByNickname(string name)
        {
            var users = _databaseContext.Users.Where(u => u.Nickname == name).Include(u => u.Projects).Include(u => u.AssignedTasks);
            var foundUser = await users.FirstOrDefaultAsync();
            if (foundUser == null) return null;
            var result = new Models.User()
            {
                Id = foundUser.Id,
                Email = foundUser.Email,
                Password = foundUser.Password,
                Nickname = foundUser.Nickname,
                Projects = foundUser.Projects.Select(p=>new Models.Project()
                {
                    Id = p.Id,
                    Description = p.Description,
                    Title = p.Title
                }).ToList(),
                AssignedTasks = foundUser.AssignedTasks.Select(t => new ProjectTask()
                {
                    Id = t.Id,
                    Title = t.Title
                }).ToList()
            };
            return result;
        }

        public async Task<Models.User> GetUserByIdAsync(int id)
        {
            var dbUser = await _databaseContext.Users.Include(u => u.AssignedTasks).Include(u=> u.Notifications).FirstOrDefaultAsync(u => u.Id == id);

            var user = new Models.User
            {
                Id = dbUser.Id,
                Email = dbUser.Email,
                Nickname = dbUser.Nickname,
                Password = dbUser.Password,
                AssignedTasks = dbUser.AssignedTasks.Select(t => new ProjectTask()
                                {
                                    Id = t.Id,
                                    Title = t.Title
                                }).ToList(),
                Notifications = dbUser.Notifications.Select(n => new Models.Notification()
                {
                    Id = n.Id,
                    Link = n.Link,
                    Text = n.Text
                }).ToList()
            };
            user.Projects = await GetProjects(user);

            return user;
        }

        public async Task<int> AddUserAsync(Models.User user)
        {
            var dbUser = new UserDB
            {
                Email = user.Email,
                Password = user.Password,
                Nickname = user.Nickname,
                Projects = new List<ProjectDB>(),
                AssignedTasks = new List<ProjectTaskDB>()
            };
            await _databaseContext.Users.AddAsync(dbUser);
            await _databaseContext.SaveChangesAsync();
            return dbUser.Id;
        }

        public async Task<bool> UpdateUserAsync(Models.User user)
        {
            var dbUser = await _databaseContext.Users.FindAsync(user.Id);
            dbUser.Email = user.Email;
            dbUser.Nickname = user.Nickname;
            dbUser.Password = user.Password;
            await _databaseContext.SaveChangesAsync();
            
            return true;
        }
        
    }
}