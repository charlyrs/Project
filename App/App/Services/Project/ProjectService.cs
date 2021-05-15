using System;
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
       

        public ProjectService(IProjectRepository projectRepository )
        {
            _projectRepository = projectRepository;
        }

        public async Task<int> AddProject(Database.Models.Project project)
        {
            if (project.Title == null || project.Description == null)
                throw new Exception("Title or description can not be empty");
            var id = await _projectRepository.AddProjectAsync(project);
            await _projectRepository.AddUserToProjectAsync(CurrentUserService.currentUserId, id);
            await _projectRepository.AddRoleToUserInProject(id, CurrentUserService.currentUserId);
            return id;
        }

        public async Task<Database.Models.Project> GetProjectByIdWithAllFields(int id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            if (project == null) throw new Exception("There is no such project");
            if (project == null) throw new Exception("there is no such project");
            project.Users = await _projectRepository.GetUsers(id);
            project.Columns = await _projectRepository.GetColumns(id);
            project.RoadMap = await _projectRepository.GetRoadMap(id);

            project.BossUsers = await _projectRepository.GetBossUsers(id);
            return project;
        }

        public async Task<bool> AddUserToProject(Database.Models.User user, Database.Models.Project project)
        {
            if (user == null || user.Id == 0 || project == null) throw new Exception("Can't perform this action");
            await _projectRepository.AddUserToProjectAsync(user.Id, project.Id);
            return true;
        }

        public async Task<bool> RemoveProjectFromTheUser(int projectId, int userId)
        {
            var users = await _projectRepository.GetUsers(userId);
            if (users.Any(u => u.Id == userId))
            {
                await _projectRepository.RemoveProjectFromUser(projectId, userId);
            }
           
            return true;
        }

        public async Task<List<Database.Models.User>> GetUsers(int projectId)
        {
            if (projectId == 0) throw new Exception("Invalid argument");
            var result = await _projectRepository.GetUsers(projectId);
            return result;
        }

        public async Task<Database.Models.RoadMap> GetRoadMap(int projectId)
        {
            var roadMap =  await _projectRepository.GetRoadMap(projectId);
            if (roadMap == null) throw new Exception("There is no such project");
            return roadMap;
        }

        public async Task<Database.Models.Project> GetProjectById(int id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            if (project == null) throw new Exception("There is no such project");
            return project;
        }

        public async Task<List<Tag>> GetTags(int projectId)
        {
            var result = await _projectRepository.GetTags(projectId);
            return result;
        }

        public async Task<bool> CheckUserRole(int userId, int projectId)
        {
            if (userId == 0 || projectId == 0) throw new Exception("Id can't be null");
            var bossUsers = await _projectRepository.GetBossUsers(projectId);
            return bossUsers.Any(u => u.Id == userId);
        }

        public async Task<List<Database.Models.User>> GetRegularUsers(int projectId)
        {
            if (projectId == 0) throw new Exception("Id can't be null");
            var result = await _projectRepository.GetRegularUsers(projectId);
            return result;
        }

        public async Task<List<Database.Models.User>> GetBossUsers(int projectId)
        {
            if (projectId == 0) throw new Exception("Id can't be null");
            var result = await _projectRepository.GetBossUsers(projectId);
            return result;
        }

        public async Task<bool> SetUsersRole(int userId, int projectId)
        {
            var users = await _projectRepository.GetUsers(projectId);
            if (users.Any(u => u.Id == userId))
            {
                await _projectRepository.AddRoleToUserInProject(projectId, userId);
            }
            return true;
        }
    }
}