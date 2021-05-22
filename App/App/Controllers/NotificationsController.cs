using System.Threading.Tasks;
using App.Services.Notification;
using App.Services.User;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly IUserService _userService;
        private readonly INotificationService _notificationService;
        public NotificationsController(IUserService userService, INotificationService notificationService)
        {
            _userService = userService;
            _notificationService = notificationService;
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

        public async Task<IActionResult> ClearNotifications()
        {
            await _notificationService.RemoveUsersNotifications(CurrentUserService.currentUserId);
            return RedirectToAction("Index");
        }
    }
}