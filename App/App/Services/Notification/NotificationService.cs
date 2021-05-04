using System.Threading.Tasks;
using App.Database.Notification;

namespace App.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }


        /*public async Task<bool> AddNotification(Database.Models.Notification notification)
        {
            
        }*/

        public  async Task<bool> FormNotification(string sender, string action, string link)
        {
            var text = new string($"{sender} {action}");
            var notification = new Database.Models.Notification()
            {
                Text = text,
                Link = link
            };
            await _notificationRepository.AddNotification(notification);
            return true;
        }
    }
}