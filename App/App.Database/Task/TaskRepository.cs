using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;

namespace App.Database.Task
{
    public class TaskRepository:ITaskRepository
    {
        private readonly ApplicationContext _databaseContext = new ApplicationContext();
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
    }
}