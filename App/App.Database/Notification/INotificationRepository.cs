using System.Threading.Tasks;

namespace App.Database.Notification
{
    public interface INotificationRepository
    {

        public Task<int> AddNotification(Models.Notification notification);
        Task<bool> AddNotificationToUser(int userId, int noteId);
    }
}