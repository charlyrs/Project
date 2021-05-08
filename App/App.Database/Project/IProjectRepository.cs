using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Database.Project
{
    public interface IProjectRepository
    {
        Task<Models.Project> GetProjectByIdAsync(int projectId);
        Task<int> AddProjectAsync(Models.Project project);
        Task<bool> AddUserToProjectAsync(int userId, int projectId);
        Task<List<Models.User>> GetUsers(Models.Project project);
        
        Task<List<Models.Column>> GetColumns(int projectId);
        Task<bool> RemoveProjectFromUser(int projectId, int userId);
        Task<bool> DeleteProject(int projectId);
        Task<Models.RoadMap> GetRoadMap(int projectId);
    }
}