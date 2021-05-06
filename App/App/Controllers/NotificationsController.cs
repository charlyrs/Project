using System.Threading.Tasks;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IUserService _userService;
        public NotificationsController(IUserService userService)
        {
            _userService = userService;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var id = CurrentUserService.currentUserId;
            var user = await _userService.GetUserById(id);
            var model = new UserViewModel(user);
            
            return View(model);
        }

        public IActionResult RedirectController(string path)
        {
            return Redirect(path);
        }
    }
}