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
        private readonly IUserRepository _userRepository;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        public async Task<IActionResult> Index()
        {
            if (HttpContext.Request.Cookies.ContainsKey("currentUserId"))
            {
                var id = int.Parse(HttpContext.Request.Cookies["currentUserId"]);
                CurrentUserService.loggedIn = true;
                CurrentUserService.currentUserId = id;
                return RedirectToAction("Index", "ProjectsList");
            }
            return RedirectToAction("Index", "Registration");

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