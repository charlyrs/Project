using System;
using System.Threading.Tasks;
using App.Database.Models;
using App.Services;
using App.Services.Project;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProjectViewController : Controller
    {
        private readonly IProjectService _projectService;
       
        private readonly IUserService _userService;
        private static int _projectId;

        public ProjectViewController(IProjectService projectService, IUserService userService)
        {
            _projectService = projectService;
            _userService = userService;
            //_projectId = projectId;
        }
        [HttpGet]
        public async Task <IActionResult> Index(int projectId)
        {
            
            var project = await _projectService.GetProjectById(projectId);
            CurrentProjectService.currentProjectId = projectId;
            var projectViewModel = new ProjectViewModel(project);
            _projectId = projectId;
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
            
            var project = await _projectService.GetProjectById(_projectId);
            var projectViewModel = new ProjectViewModel(project);
            return View(projectViewModel);
        }
        
        //Leave project
        [HttpPost]
        public async Task<IActionResult> ProjectInfo()
        {
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"] ?? throw new InvalidOperationException());
            await _projectService.RemoveProjectFromTheUser(_projectId, id);
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
            var project = await _projectService.GetProjectById(_projectId);
            await _projectService.AddUserToProject(user, project);
            return RedirectToAction("ProjectInfo");
        }
        public IActionResult SetTaskView(ProjectTask task)
        {
            ViewBag.task = task;
            return RedirectToAction("Index");
        }
        
    }
}