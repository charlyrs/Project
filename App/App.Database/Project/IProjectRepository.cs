using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.DatabaseModels;

namespace App.Database.Project
{
    public interface IProjectRepository
    {
        Task<Models.Project> GetProjectByIdAsync(int projectId);
        Task<int> AddProjectAsync(Models.Project project);
        Task<bool> AddUserToProjectAsync(int userId, int projectId);
        Task<List<Models.User>> GetUsers(int projectId);
        
        Task<List<Models.Column>> GetColumns(int projectId);
        Task<bool> RemoveProjectFromUser(int projectId, int userId);
        Task<bool> DeleteProject(int projectId);
        Task<Models.RoadMap> GetRoadMap(int projectId);
        Task<List<Models.Tag>> GetTags(int projectId);
        Task<bool> AddRoleToUserInProject(int projectId, int userId);
        Task<List<Models.User>> GetBossUsers(int projectId);
        Task<List<Models.User>> GetRegularUsers(int projectId);
        

    }
}