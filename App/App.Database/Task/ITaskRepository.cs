using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.Task
{
    public interface ITaskRepository
    {
        Task<int> AddTask(ProjectTask task);
        Task<ProjectTask> GetTaskById(int id);
        Task<bool> AddUserToTask(int userId, int taskId);

    }
}