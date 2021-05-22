using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Database.Notification
{
    public interface INotificationRepository
    {

        public Task<int> AddNotification(Models.Notification notification);
        Task<bool> AddNotificationToUser(int userId, int noteId);
        Task<List<int>> GetUsersNotificationsId(int userId);
        Task<bool> RemoveNotificationFromUser(int userId, int noteId);
        Task<bool> DeleteNotification(int id);
    }
}