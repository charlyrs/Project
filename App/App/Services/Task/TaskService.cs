using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (string.IsNullOrEmpty(task.Title)) throw new Exception("Task title can't be empty");
            var id = await _taskRepository.AddTask(task);
            return id;
        }

        public async Task<ProjectTask> FindTaskById(int id)
        {
            var task = await _taskRepository.GetTaskById(id);
            if (task == null) throw new Exception("There is no such task");
            task.Comments = await _taskRepository.GetCommentsByTaskId(id);
            return task;
        }

        public async Task<bool> AddUserToTask(int userId, int taskId)
        {
            if (userId == 0 || taskId == 0) throw new Exception("Id can't be zero");
            await _taskRepository.AddUserToTask(userId, taskId);
            return true;
        }

        public async Task<bool> LinkTaskToRoadMapStep(int taskId, int stepId)
        {
            if (stepId == 0 || taskId == 0) throw new Exception("Id can't be zero");
            await _taskRepository.LinkTaskToRoadMapStep(taskId, stepId);
            return true;
        }

        public async Task<Database.Models.Project> GetTasksProject(ProjectTask task)
        {
            if (task.Id == 0) throw new Exception("Id can't be zero");
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
            if (string.IsNullOrEmpty(tag.Text)) throw new Exception("Tag title can't be empty");
            var tagId = await _tagRepository.AddTag(tag);
            await _tagRepository.AddTagToTask(tagId, taskId);
            return true;
        }

        public async Task<bool> LinkTagToTask(int tagId, int taskId)
        {
            if (tagId == 0 || taskId == 0) throw new Exception("Id can't be zero");
            await _tagRepository.AddTagToTask(tagId, taskId);
            return true;
        }

        public async Task<bool> AddCommentToTask(string text, int userId, int taskId)
        {
            if (string.IsNullOrEmpty(text)) throw new Exception("Comment can't be empty");
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
                Text = text,
                Time = DateTime.Now
            };
            await _taskRepository.AddCommentToTask(comment);
            return true;
        }

        public async Task<Tag> GetTagById(int tagId)
        {
            var tag = await _tagRepository.GetTagByIdWithTasks(tagId);
            return tag;
        }

        public async Task<bool> ArchiveTask(int taskId)
        {
            await _taskRepository.AddTaskToArchive(taskId);
            await _taskRepository.RemoveTaskFromColumn(taskId);
            return true;
        }

        
    }
}