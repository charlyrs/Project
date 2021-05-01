using System.Threading.Tasks;

namespace App.Services.Project
{
    public interface IProjectService
    {
        Task<int> AddProject(Database.Models.Project project);
        Task<Database.Models.Project> GetProjectById(int id);
        Task<bool> AddUserToProject(Database.Models.User user, Database.Models.Project project);
        Task<bool> RemoveProjectFromTheUser(int projectId, int userId);
    }
}