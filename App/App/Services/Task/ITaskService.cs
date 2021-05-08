using System.Threading.Tasks;
using App.Database.Models;

namespace App.Services.Task
{
    public interface ITaskService
    {
        Task<int> AddTask(ProjectTask task);
        Task<ProjectTask> FindTaskById(int id);
        Task<bool> AddUserToTask(int userId, int taskId);
        Task<bool> LinkTaskToRoadMapStep(int taskId, int stepId);
        Task<Database.Models.Project> GetTasksProject(ProjectTask task);
    }
}