using System;
using System.Threading.Tasks;
using App.Database.Notification;
using App.Services.User;

namespace App.Services.Notification
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository _notificationRepository;
        public NotificationService(INotificationRepository notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }
        
        public  async Task<bool> FormNotification(string text, string link, int recieverId)
        {
            if (link == null || recieverId == 0) throw new Exception("Invalid notification data");
            var notification = new Database.Models.Notification()
            {
                Text = text,
                Link = link
            };
            var id = await _notificationRepository.AddNotification(notification);
            await _notificationRepository.AddNotificationToUser(recieverId, id);
            return true;
        }
        

        public async Task<bool> RemoveUsersNotifications(int userId)
        {
            var noteIds = await _notificationRepository.GetUsersNotificationsId(userId);
            foreach (var id in noteIds)
            {
                await _notificationRepository.RemoveNotificationFromUser(userId, id);
            }
            return true;
        }
    }
}