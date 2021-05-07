using System;
using System.Threading.Tasks;
using App.Services;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!CurrentUserService.loggedIn) return RedirectToAction("Index", "Registration");
            var id = CurrentUserService.currentUserId;
            var user = await _userService.GetUserById(id);
            var userViewModel = new UserViewModel(user);
            
            return View(userViewModel);
        }

       
        [HttpGet]
        public async Task<IActionResult> EditUserData()
        {
            var id = CurrentUserService.currentUserId;
            var user = await _userService.GetUserById(id);
            var userViewModel = new UserViewModel(user);
            return View(userViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> EditUserData(string username, string email)
        {
            var id = CurrentUserService.currentUserId;
            var user = await _userService.GetUserById(id);
            user.Nickname = username;
            user.Email = email;
            await _userService.UpdateUserData(user);
            
            return RedirectToAction("Index","Account");
        }
        [HttpGet]
        public async Task<IActionResult> EditPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ToEditPassword()
        {
            return RedirectToAction("EditPassword");
        }
        [HttpPost]
        public async Task<IActionResult> EditPassword(string password, string newPassword)
        {
            var id = CurrentUserService.currentUserId;
            await _userService.UpdateUserPassword(password, newPassword, id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> AllTasks()
        {
            var id = CurrentUserService.currentUserId;
            var user = await _userService.GetUserById(id);
            var model = new UserViewModel(user);
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            HttpContext.Response.Cookies.Append("currentUserId","0");
            CurrentUserService.currentUserId = 0;
            CurrentUserService.loggedIn = false;
            CurrentProjectService.currentProjectId = 0;
            return RedirectToAction("Index", "Registration");
        }
    }
}