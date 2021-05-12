using System;
using System.Threading.Tasks;
using App.Database.Models;
using App.Database.Tag;
using App.Database.Task;

namespace App.Services.Task
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITagRepository _tagRepository;
        public TaskService(ITaskRepository taskRepository, ITagRepository tagRepository)
        {
            _taskRepository = taskRepository;
            _tagRepository = tagRepository;
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

        public async Task<bool> AddTagToTask(Tag tag, int taskId)
        {
            var tagId = await _tagRepository.AddTag(tag);
            await _tagRepository.AddTagToTask(tagId, taskId);
            return true;
        }

        public async Task<bool> LinkTagToTask(int tagId, int taskId)
        {
            await _tagRepository.AddTagToTask(tagId, taskId);
            return true;
        }

        public async Task<bool> AddCommentToTask(string text, int userId, int taskId)
        {
            var comment = new Comment()
            {
                Task = new ProjectTask()
                {
                    Id = taskId
                },
                User = new Database.Models.User()
                {
                    Id = userId
                },
                Text = text
            };
            await _taskRepository.AddCommentToTask(comment);
            return true;
        }

        public async Task<Tag> GetTagById(int tagId)
        {
            var tag = await _tagRepository.GetTagByIdWithTasks(tagId);
            return tag;
        }
    }
}