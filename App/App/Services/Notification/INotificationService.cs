using System.Threading.Tasks;

namespace App.Services.Notification
{
    public interface INotificationService
    {
        Task<bool> FormNotification(string text, string link, int recieverId);
        Task<bool> RemoveUsersNotifications(int userId);
        
    }
}