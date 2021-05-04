using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Column
{
    public class ColumnRepository:IColumnRepository
    {
        private readonly ApplicationContext _databaseContext = new ApplicationContext();
        
        public ColumnRepository(ApplicationContext applicationContext)
        {
            _databaseContext = applicationContext;
        }
        public async Task<List<ProjectTask>> GetColumnTasks(int columnId)
        {
            var column = _databaseContext.Columns.Where(c => c.Id == columnId).Include(c => c.Tasks).FirstOrDefault();
            var tasks = column.Tasks.Select(t => new ProjectTask()
            {
                Id = t.Id,
                Title = t.Title,
                Deadline = t.Deadline,
                Column = new Models.Column()
                {
                    Title = column.Title,
                    Id = columnId,
                },
                AssignedUsers = new List<Models.User>()
            }).ToList();
            return tasks;

        }

        public Task<int> AddColumn(Models.Column column)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Models.Column> GetColumnById(int id)
        {
            var columnDb = await _databaseContext.Columns.FindAsync(id);
            var result = new Models.Column()
            {
                Id = columnDb.Id,
               
                Title = columnDb.Title,
            };
            return result;

        }
        

        public async Task<bool> AddTaskToColumn(ProjectTask task, int columnId)
        {
            //var task = await _databaseContext.Tasks.FindAsync(taskId);
            var taskDb = new ProjectTaskDB()
            {
                Title = task.Title,
                AssignedUsers = new List<UserDB>(),
                Deadline = task.Deadline

            };
                var column = await _databaseContext.Columns.FindAsync(columnId);
                taskDb.Column = column;
                await _databaseContext.Tasks.AddAsync(taskDb);
                await _databaseContext.SaveChangesAsync();
                return true;

        }

        public async Task<Models.Project> GetColumnsProject(int columnId)
        {
            var s = _databaseContext.Projects.Where(p => p.Columns.Any(c => c.Id == columnId));
            var foundProject = s.FirstOrDefault();
            var result = new Models.Project()
            {
                Id = foundProject.Id
            };
            return result;
        }

        public async Task<bool> DeleteColumn(int columnId)
        {
            var column = await _databaseContext.Columns.Include(c=>c.Tasks).FirstOrDefaultAsync(c => c.Id == columnId);
            _databaseContext.Tasks.RemoveRange(column.Tasks);
            _databaseContext.Columns.Remove(column);
            await _databaseContext.SaveChangesAsync();
            return true;

        }
    }
}