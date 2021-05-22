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
                Deadline = task.Deadline,
                Comments = new List<CommentDB>()
            };
                await _databaseContext.Tasks.AddAsync(taskDb);
                await _databaseContext.SaveChangesAsync();
                return taskDb.Id;
            
        }

        public async Task<ProjectTask> GetTaskById(int id)
        {
            var task = await _databaseContext.Tasks.
                Include(t => t.AssignedUsers).
                Include(t => t.Tags).
                Include(t => t.RmStep).
                Include(t => t.RmStep).
                Include(t => t.Comments).
                FirstOrDefaultAsync(t => t.Id == id);
            var result = new ProjectTask
            {
                Id = task.Id,
                Title = task.Title,
                AssignedUsers = task.AssignedUsers.Select(u => new Models.User
                {
                    Id = u.Id,
                    Email = u.Email,
                    Nickname = u.Nickname
                }).ToList(),
                Deadline = task.Deadline,
                Tags = task.Tags.Select(tag => new Models.Tag()
                {
                    Id = tag.Id,
                    Text = tag.Text
                }).ToList(),
                
            };
            if (task.RmStep != null)
            {
                result.RmStep = new RMStep()
                {
                    Id = task.RmStep.Id,
                    Title = task.RmStep.Title
                };
            }
            
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

        public async Task<bool> LinkTaskToRoadMapStep(int taskId, int stepId)
        {
            var task = await _databaseContext.Tasks.Include(t => t.RmStep).FirstOrDefaultAsync(t => t.Id == taskId);
            var step = await _databaseContext.RoadMapSteps.FindAsync(stepId);
            task.RmStep = step;
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<Models.Project> GetTasksProject(ProjectTask task)
        {
            var dbTask = await _databaseContext.Tasks.Include(t => t.Column).FirstOrDefaultAsync(t => t.Id == task.Id);
            var project = await _databaseContext.Projects.Include(p => p.Columns)
                .FirstOrDefaultAsync(p => p.Columns.Any(c => c.Id == dbTask.Column.Id));
            var result = new Models.Project()
            {
                Id = project.Id,
                Title = project.Title,
                Description = project.Description
            };
            return result;
        }

        public async Task<bool> UpdateTaskDeadline(ProjectTask task)
        {
            var dbTask = await _databaseContext.Tasks.FindAsync(task.Id);
            dbTask.Deadline = task.Deadline;
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddCommentToTask(Comment comment)
        {
            var commentDb = new CommentDB()
            {
                Time = comment.Time,
                Task = await _databaseContext.Tasks.FindAsync(comment.Task.Id),
                Text = comment.Text,
                User = await _databaseContext.Users.FindAsync(comment.User.Id)
            };
            await _databaseContext.Comments.AddAsync(commentDb);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<Comment>> GetCommentsByTaskId(int taskId)
        {
            var comments = await _databaseContext.Comments.Include(c => c.User)
                .Where(c => c.Task.Id == taskId).ToListAsync();
            var result = comments.Select(c => new Comment()
            {
                Id = c.Id,
                Text = c.Text,
                Time = c.Time,
                User = new Models.User()
                {
                    Id = c.User.Id,
                    Nickname = c.User.Nickname,
                    Email = c.User.Email
                }
            }).ToList();
            return result;
        }

        public async Task<bool> RemoveTaskFromColumn(int taskId)
        {
            var task = await _databaseContext.Tasks.Include(t => t.Column).FirstOrDefaultAsync(t => t.Id == taskId);
            var column = task.Column;
            column.Tasks.Remove(task);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AddTaskToArchive(int taskId)
        {
            var task = await _databaseContext.Tasks.Include(t => t.Column.Project).FirstOrDefaultAsync(t => t.Id == taskId);
            task.Project = task.Column.Project;
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}