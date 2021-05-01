﻿using System.Threading.Tasks;
using App.Services.Project;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProjectViewController : Controller
    {
        private readonly IProjectService _projectService;
        private static ProjectViewModel _projectViewModel;
        private static int _projectId;

        public ProjectViewController(IProjectService projectService)
        {
            _projectService = projectService;
            //_projectId = projectId;
        }
        [HttpGet]
        public async Task <IActionResult> Index(int projectId)
        {
            var project = await _projectService.GetProjectById(projectId);
            var projectViewModel = new ProjectViewModel(project);
            _projectId = projectId;
            _projectViewModel = projectViewModel;
            return View(projectViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> ProjectInfo( )
        {
            return View(_projectViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> ProjectInfo(bool post)
        {
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
            await _projectService.RemoveProjectFromTheUser(_projectId, id);
            return RedirectToAction("Index", "ProjectsList");

        }
        
    }
}