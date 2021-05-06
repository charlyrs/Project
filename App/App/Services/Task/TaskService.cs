using System.Threading.Tasks;
using App.Database.Models;
using App.Database.Task;

namespace App.Services.Task
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<int> AddTask(ProjectTask task)
        {
            // To do:
            // check input
            var id = await _taskRepository.AddTask(task);
            return id;
        }

        public async Task<ProjectTask> FindTaskById(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            return task;
        }

        public async Task<bool> AddUserToTask(int userId, int taskId)
        {
            await _taskRepository.AddUserToTask(userId, taskId);
            return true;
        }
    }
}