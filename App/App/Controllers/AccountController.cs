using System;
using System.Threading.Tasks;
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
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
            var user = await _userService.GetUserById(id);
            var userViewModel = new UserViewModel(user);
            
            return View(userViewModel);
        }

       
        [HttpGet]
        public async Task<IActionResult> EditUserData()
        {
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
            var user = await _userService.GetUserById(id);
            var userViewModel = new UserViewModel(user);
            return View(userViewModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> EditUserData(string username, string email)
        {
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
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
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"] ?? throw new InvalidOperationException());
            await _userService.UpdateUserPassword(password, newPassword, id);
            return RedirectToAction("Index");
        }
    }
}