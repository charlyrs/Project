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
            var id = await _taskRepository.AddTask(task);
            return id;
        }
    }
}