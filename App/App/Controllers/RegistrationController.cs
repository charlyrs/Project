using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;
using App.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IRegistrationService _registrationService;
        private readonly IUserService _userService;

        public RegistrationController(IRegistrationService registrationService, IUserService userService)
        {
            _registrationService = registrationService;
            _userService = userService;

        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password, string username)
        {
            var user = new User()
            {
                Email = email,
                Password = password,
                Nickname = username,
                Projects = new List<Project>()
            };
            var id = await _registrationService.AddUser(user);
            HttpContext.Response.Cookies.Append("currentUserId",id.ToString());
            CurrentUserService.currentUserId = id;
            CurrentUserService.loggedIn = true;
            return RedirectToAction("Index", "ProjectsList");
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(string username, string password)
        {
            var user = await _userService.GetUserByNickname(username);
            if (user!=null && user.Password==password)
            {
                HttpContext.Response.Cookies.Append("currentUserId",user.Id.ToString());
                CurrentUserService.loggedIn = true;
                CurrentUserService.currentUserId = user.Id;
                return RedirectToAction("Index", "ProjectsList");
            }
            return View();
        }
    }
}