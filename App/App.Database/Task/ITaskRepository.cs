using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.Task
{
    public interface ITaskRepository
    {
        Task<int> AddTask(ProjectTask task);
        Task<ProjectTask> GetTaskById(int id);
        Task<bool> AddUserToTask(int userId, int taskId);
        Task<bool> LinkTaskToRoadMapStep(int taskId, int stepId);
        Task<Models.Project> GetTasksProject(ProjectTask task);
        Task<bool> UpdateTaskDeadline(ProjectTask task);
        Task<bool> AddCommentToTask(Comment comment);
        Task<List<Comment>> GetCommentsByTaskId(int taskId);
        Task<bool> RemoveTaskFromColumn(int taskId);
        Task<bool> AddTaskToArchive(int taskId);

    }
}