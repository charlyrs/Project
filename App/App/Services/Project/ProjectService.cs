using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using App.Database.Models;
using App.Database.Project;
using App.Database.User;
using App.Services.User;

namespace App.Services.Project
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICheckInputService _checkInputService;

        public ProjectService(IProjectRepository projectRepository, ICheckInputService checkInputService )
        {
            _projectRepository = projectRepository;
            
            _checkInputService = checkInputService;
        }

        public async Task<int> AddProject(Database.Models.Project project)
        {
            var id = await _projectRepository.AddProjectAsync(project);
            await _projectRepository.AddUserToProjectAsync(CurrentUserService.currentUserId, id);
            await _projectRepository.AddRoleToUserInProject(id, CurrentUserService.currentUserId);
            return id;
        }

        public async Task<Database.Models.Project> GetProjectByIdWithAllFields(int id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            project.Users = await _projectRepository.GetUsers(id);
            project.Columns = await _projectRepository.GetColumns(id);
            project.RoadMap = await _projectRepository.GetRoadMap(id);
            var role = await _projectRepository.GetRole(id);
            project.BossUsers = role.BossUsers.Select(u => new Database.Models.User
            {
                Id = u.Id,
                Nickname = u.Nickname,
                Email = u.Email
            }).ToList();
            return project;
        }

        public async Task<bool> AddUserToProject(Database.Models.User user, Database.Models.Project project)
        {
            await _projectRepository.AddUserToProjectAsync(user.Id, project.Id);
            return true;
        }

        public async Task<bool> RemoveProjectFromTheUser(int projectId, int userId)
        {
            await _projectRepository.RemoveProjectFromUser(projectId, userId);
            return true;

        }

        public async Task<List<Database.Models.User>> GetUsers(int projectId)
        {
            //var project = await _projectRepository.GetProjectByIdAsync(projectId);
            var result = await _projectRepository.GetUsers(projectId);
            return result;
        }

        public async Task<Database.Models.RoadMap> GetRoadMap(int projectId)
        {
            var rm =  await _projectRepository.GetRoadMap(projectId);
            return rm;
        }

        public async Task<Database.Models.Project> GetProjectById(int id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            return project;
        }

        public async Task<List<Tag>> GetTags(int projectId)
        {
            var result = await _projectRepository.GetTags(projectId);
            return result;
        }

        public async Task<bool> CheckUserRole(int userId, int projectId)
        {
            var role = await _projectRepository.GetRole(projectId);
            return role.BossUsers.Any(u => u.Id == userId);
        }

        public async Task<List<Database.Models.User>> GetRegularUsers(int projectId)
        {
            var result = await _projectRepository.GetRegularUsers(projectId);
            return result;
        }

        public async Task<List<Database.Models.User>> GetBossUsers(int projectId)
        {
            var role = await _projectRepository.GetRole(projectId);
            var result = role.BossUsers.Select(u => new Database.Models.User
            {
                Id = u.Id,
                Nickname = u.Nickname,
                Email = u.Email
            }).ToList();
            return result;
        }

        public async Task<bool> SetUsersRole(int userId, int projectId)
        {
            await _projectRepository.AddRoleToUserInProject(projectId, userId);
            return true;
        }
    }
}