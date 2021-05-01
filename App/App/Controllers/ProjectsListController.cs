using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;
using App.Services.Project;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class ProjectsListController : Controller
    {
        private UserViewModel _userViewModel;
        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        public ProjectsListController(IUserService userService, IProjectService projectService)
        {
            _userService = userService;
            _projectService = projectService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var user = await _userService.GetUserById(CurrentUserService.currentUserId);
            _userViewModel = new UserViewModel(user);
            return View(_userViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(string title, string description)
        {
            var project = new Project()
            {
                Title = title,
                Columns = new List<Column>(),
                Description = description
            };
            await _projectService.AddProject(project);
            return RedirectToAction("Index", "ProjectsList");
        }

        /*[HttpPost]
        public IActionResult Index(bool post)
        {
            return RedirectToAction("Index", "AddProject");
        }*/
    }
}