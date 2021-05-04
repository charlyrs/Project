using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.Column;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Project
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationContext _databaseContext;
        private readonly IColumnRepository _columnRepository;

        public ProjectRepository(IColumnRepository columnRepository, ApplicationContext applicationContext)
        {
            _databaseContext = applicationContext;
            _columnRepository = columnRepository;
        }
        public async Task<Models.Project> GetProjectByIdAsync(int projectId)
        {
            var project = await _databaseContext.Projects.FindAsync(projectId);
            var result = new Models.Project()
            {
                Description = project.Description,
                Id = projectId,
                Title = project.Title,
                    
            };
            return result;
           
        }
        public async Task<int> AddProjectAsync(Models.Project project)
        {
            var dbProject = new ProjectDB()
            {
                Description = project.Description,
                Title = project.Title,
                Users = new List<UserDB>(),
                Columns = new List<ColumnDB>()
            };
            await _databaseContext.Projects.AddAsync(dbProject);
            await _databaseContext.SaveChangesAsync();
            await AddDefaultColumnsToProject(dbProject.Id);
            return dbProject.Id;
           
        }
        public async Task<bool> AddUserToProjectAsync(int userId, int projectId)
        {
            var user = await _databaseContext.Users.FindAsync(userId);
            var project = await _databaseContext.Projects.Include(p => p.Users).FirstOrDefaultAsync(p=> p.Id==projectId);
            project.Users.Add(user);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
        public async Task<List<Models.User>> GetUsers(Models.Project project)
        {
            var users = _databaseContext.Users.Include(u=> u.AssignedTasks).Where(u => u.Projects.Any(p => p.Id == project.Id));
            var usersList = await users.ToListAsync();
            var result = usersList.Select(u => new Models.User()
            {
                Id = u.Id,
                Email = u.Email,
                Nickname = u.Nickname,
                Password = u.Password,
                AssignedTasks = u.AssignedTasks.Select(t => new ProjectTask()
                {
                    Id = t.Id,
                    Title = t.Title
                }).ToList()

            }).ToList();
                return result;
        }
        public async Task<bool> AddDefaultColumnsToProject(int projectId)
        {
           
            var project = await _databaseContext.Projects.FindAsync(projectId);

            var column1 = new ColumnDB() {Title = "To Do", Project = project, Tasks = new List<ProjectTaskDB>()};
            var column2 = new ColumnDB() { Title = "In Progress", Project = project, Tasks = new List<ProjectTaskDB>()};
            var column3 = new ColumnDB() { Title = "Done", Project = project, Tasks = new List<ProjectTaskDB>()};

            await _databaseContext.Columns.AddAsync(column1);
            await _databaseContext.Columns.AddAsync(column2);
            await _databaseContext.Columns.AddAsync(column3);
            await _databaseContext.SaveChangesAsync();
            return true;

        }
        public async Task<List<Models.Column>> GetColumns(int projectId)
        {
            var columns = _databaseContext.Columns.Where(c => c.Project.Id == projectId).Include(c => c.Tasks);
            var list = await columns.ToListAsync();
            var res = list.Select(c => new Models.Column()
            {
                Id = c.Id,
                Project = new Models.Project()
                {
                    Id = c.Project.Id
                },
                Title = c.Title,
                Tasks = c.Tasks.Select(t => new ProjectTask()
                {
                    Id = t.Id,
                    Deadline = t.Deadline,
                    Title = t.Title,
                        
                }).ToList()

            }).ToList();
                
            return res;
        }

        public async Task<bool> RemoveProjectFromUser(int projectId, int userId)
        {
            var user = await _databaseContext.Users.Include(u => u.Projects).FirstOrDefaultAsync(u => u.Id == userId);
            var project = await _databaseContext.Projects.Include(p => p.Users).FirstOrDefaultAsync(p => p.Id == projectId);
            user.Projects.Remove(project);
            await _databaseContext.SaveChangesAsync();
            /*if (project.Users.Count == 0)
            {
                await DeleteProject(projectId);
            }*/

            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteProject(int projectId)
        {
            var project = await _databaseContext.Projects.Include(p => p.Columns)
                .FirstOrDefaultAsync(p => p.Id == projectId);
            foreach (var column in project.Columns)
            {
                await _columnRepository.DeleteColumn(column.Id);
            }

            _databaseContext.Projects.Remove(project);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}