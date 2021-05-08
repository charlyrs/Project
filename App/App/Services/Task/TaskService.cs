using System;
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

        public async Task<bool> LinkTaskToRoadMapStep(int taskId, int stepId)
        {
            await _taskRepository.LinkTaskToRoadMapStep(taskId, stepId);
            return true;
        }

        public async Task<Database.Models.Project> GetTasksProject(ProjectTask task)
        {
            var project = await _taskRepository.GetTasksProject(task);
            return project;
        }

        public  async Task<bool> SetDeadline(DateTime deadline, int taskId)
        {
            var task = await _taskRepository.GetTaskById(taskId);
            task.Deadline = deadline;
            await _taskRepository.UpdateTaskDeadline(task);
            return true;
        }

        
    }
}