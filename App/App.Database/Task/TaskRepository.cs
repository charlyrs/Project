using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Task
{
    public class TaskRepository:ITaskRepository
    {
        private readonly ApplicationContext _databaseContext ;

        public TaskRepository(ApplicationContext applicationContext)
        {
            _databaseContext = applicationContext;
        }
        
        public async Task<int> AddTask(ProjectTask task)
        {

            var taskDb = new ProjectTaskDB()
            {
                Title = task.Title,
                AssignedUsers = new List<UserDB>(),
                Column = new ColumnDB()
                {
                    Id = task.Column.Id
                },
                Deadline = task.Deadline
            };
                await _databaseContext.Tasks.AddAsync(taskDb);
                await _databaseContext.SaveChangesAsync();
                return taskDb.Id;
            
        }

        public async Task<ProjectTask> GetTaskById(int id)
        {
            var task = await _databaseContext.Tasks.Include(t => t.AssignedUsers).FirstOrDefaultAsync(t => t.Id ==id);
            var result = new ProjectTask()
            {
                Id = task.Id,
                Title = task.Title,
                AssignedUsers = task.AssignedUsers.Select(u =>new Models.User()
                {
                    Id = u.Id,
                    Email = u.Email,
                    Nickname = u.Nickname

                }).ToList(),
                Deadline = task.Deadline
            };
            return result;
        }

        public async Task<bool> AddUserToTask(int userId, int taskId)
        {
            var user = await _databaseContext.Users.FindAsync(userId);
            var task = await _databaseContext.Tasks.Include(t => t.AssignedUsers)
                .FirstOrDefaultAsync(t => t.Id == taskId);
            task.AssignedUsers.Add(user);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}