using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;
using App.Services;
using App.Services.Notification;
using App.Services.Project;
using App.Services.RoadMap;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProjectViewController : Controller
    {
        private readonly IProjectService _projectService;
        private readonly IUserService _userService;
        private readonly IRoadMapService _roadMapService;
        private readonly INotificationService _notificationService;
        private static string _path;

        public ProjectViewController(IProjectService projectService, IUserService userService, INotificationService notificationService, IRoadMapService roadMapService)
        {
            _projectService = projectService;
            _userService = userService;
            _notificationService = notificationService;
            _roadMapService = roadMapService;
            //_projectId = projectId;
        }
        [HttpGet]
        public async Task <IActionResult> Index(int projectId)
        {
            _path = new string($"{HttpContext.Request.Path}{HttpContext.Request.QueryString}");
            var project = await _projectService.GetProjectByIdWithAllFields(projectId);
            CurrentProjectService.currentProjectId = projectId;
            CurrentProjectService.bossRole =
                await _projectService.CheckUserRole(CurrentUserService.currentUserId, projectId);
            var projectViewModel = new ProjectViewModel(project) {BossRole = CurrentProjectService.bossRole};

            return View(projectViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> ProjectInfo(bool message)
        {
            if (message)
            {
                ViewBag.userMessage = "There is no such user";
                ViewBag.messageColor = "red";
            }
            else
            {
                ViewBag.userMessage = "Add new user to project";
                ViewBag.messageColor = "#60bcdc";
            }
            
            var project = await _projectService.GetProjectByIdWithAllFields(CurrentProjectService.currentProjectId);
            var projectViewModel = new ProjectViewModel(project) {BossRole = CurrentProjectService.bossRole};
            return View(projectViewModel);
        }
        
        //Leave project
        [HttpPost]
        public async Task<IActionResult> ProjectInfo()
        {
            var id = CurrentUserService.currentUserId;
            await _projectService.RemoveProjectFromTheUser(CurrentProjectService.currentProjectId, id);
            return RedirectToAction("Index", "ProjectsList");

        }

        [HttpPost]
        public async Task<IActionResult> AddUserToProject(string username)
        {  
            var user = await _userService.GetUserByNickname(username);
            if (user == null)
            {
                return RedirectToAction("ProjectInfo", new {message = true});
            }
            var project = await _projectService.GetProjectByIdWithAllFields(CurrentProjectService.currentProjectId);
            var added = await _projectService.AddUserToProject(user, project);
            if (added)
            {
                
                await _notificationService.FormNotification("You were added to new project", _path, user.Id);
            }
            return RedirectToAction("ProjectInfo");
        } 
        public async Task<IActionResult> RoadMap()
        {
            var id = CurrentProjectService.currentProjectId;
            var project = await _projectService.GetProjectByIdWithAllFields(id);
            var model = new RoadMapViewModel()
            {
                Steps = project.RoadMap.Steps
            };
            return View(model);
        }

        public async Task<IActionResult> AddStep(string title)
        {
            var step = new RMStep()
            {
                Title = title,
                RoadMap = await _projectService.GetRoadMap(CurrentProjectService.currentProjectId)
            };
            await _roadMapService.AddStep(step);
            return RedirectToAction("RoadMap");
        }
        [HttpGet]
        public async Task<IActionResult> StepTasks(int stepId)
        {
            var step = await _roadMapService.GetStepByIdWithTasks(stepId);
            var model = new RMStepViewModel()
            {
                Title = step.Title,
                Tasks = step.LinkedTasks
            };
            return View(model);
        }

        public async Task<IActionResult> ProjectSettings()
        {
            var bossUsers =await _projectService.GetBossUsers(CurrentProjectService.currentProjectId);
            var regularUsers = await _projectService.GetRegularUsers(CurrentProjectService.currentProjectId);
            var model = new RoleViewModel()
            {
                BossUsers = bossUsers,
                RegularUsers = regularUsers
            };
            return View(model);
        }

        public async Task<IActionResult> SetRoleToTheUser(int userId)
        {
            await _projectService.SetUsersRole(userId, CurrentProjectService.currentProjectId);
            await _notificationService.FormNotification("You got a new role in project", _path, userId);
            return RedirectToAction("ProjectSettings");
        }

        

    }
}