using System.Linq;
using System.Threading.Tasks;
using App.Services;
using App.Services.Notification;
using App.Services.Project;
using App.Services.Task;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class TaskViewController : Controller
    {

        private readonly ITaskService _taskService;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        private readonly INotificationService _notificationService;
        private static int _taskId;
        private static string _link;

        public TaskViewController(ITaskService taskService, IUserService userService, IProjectService projectService, INotificationService notificationService)
        {
            _taskService = taskService;
            _userService = userService;
            _projectService = projectService;
            _notificationService = notificationService;
        }

        // GET
        public async Task<IActionResult> Index(int taskId)
        {
            _link = new string($"{HttpContext.Request.Path}{HttpContext.Request.QueryString}");
            var task = await _taskService.FindTaskById(taskId);
            var project = await _taskService.GetTasksProject(task);
            CurrentProjectService.currentProjectId = project.Id;
            var users = await _projectService.GetUsers(CurrentProjectService.currentProjectId);
            _taskId = taskId;
            ViewBag.projectUsers = users.Where(u => u.AssignedTasks.TrueForAll(t => t.Id != _taskId));
            var taskViewModel = new TaskViewModel(task);
            var roadMap = await _projectService.GetRoadMap(CurrentProjectService.currentProjectId);
            ViewBag.Steps = roadMap.Steps;
            return View(taskViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> AssignUserToTask(string username)
        {
            var task = await _taskService.FindTaskById(_taskId);
            var user = await _userService.GetUserByNickname(username);
            await _taskService.AddUserToTask(user.Id, _taskId);
            await _notificationService.FormNotification($"You were assigned to task {task.Title}", _link, user.Id);
            return RedirectToAction("Index", new {taskId = _taskId});
        }

        public async Task<IActionResult> LinkTaskToStep(int stepId)
        {
           
            await _taskService.LinkTaskToRoadMapStep(_taskId, stepId);
            return RedirectToAction("Index", new {taskId = _taskId});
        }

}
}