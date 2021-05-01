using System.Threading.Tasks;
using App.Database.Models;
using App.Services.Project;
using App.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AddUserToProjectController : Controller
    {
        private static Project _project;

        private readonly IUserService _userService;
        private readonly IProjectService _projectService;
        public AddUserToProjectController(IUserService userService, IProjectService projectService)
        {
            _userService = userService;
            _projectService = projectService;

        }
        [HttpGet]
        public IActionResult Index(Project project)
        {
            _project = project;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FindUser(string name)
        {
            var model = await _userService.GetUserByNickname(name);
            if (model == null)
            {
                //TO DO:
                //message
            }
            await _projectService.AddUserToProject(model, _project);
            return RedirectToAction("Index","Home");

        }
    }
}