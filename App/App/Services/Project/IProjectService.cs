using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Services.Project
{
    public interface IProjectService
    {
        Task<int> AddProject(Database.Models.Project project);
        Task<Database.Models.Project> GetProjectByIdWithAllFields(int id);
        Task<bool> AddUserToProject(Database.Models.User user, Database.Models.Project project);
        Task<bool> RemoveProjectFromTheUser(int projectId, int userId);
        Task<List<Database.Models.User>> GetUsers(int projectId);
        Task<Database.Models.RoadMap> GetRoadMap(int projectId);
        Task<Database.Models.Project> GetProjectById(int id);
    }
}