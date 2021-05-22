using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Database.Column;
using App.Database.Models;
using App.Database.Project;
using App.Database.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App.Models;
using App.Services.User;
using App.ViewModels;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserService _userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            if (!HttpContext.Request.Cookies.ContainsKey("currentUserId"))
                return RedirectToAction("Index", "Registration");
            var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
            var user = await _userService.GetUserById(id);
            if (user == null) return RedirectToAction("Index", "Registration");
            CurrentUserService.loggedIn = true;
            CurrentUserService.currentUserId = id;
            return RedirectToAction("Index", "ProjectsList");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}