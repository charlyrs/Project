using System;
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
        Task<bool> SetDeadline(DateTime deadline, int taskId);

        Task<bool> AddTagToTask(Tag tag, int taskId);
        Task<bool> LinkTagToTask(int tagId, int taskId);
        Task<bool> AddCommentToTask(string text, int userId, int taskId);
        Task<Tag> GetTagById(int tagId);
        Task<bool> ArchiveTask(int taskId);
    }
}