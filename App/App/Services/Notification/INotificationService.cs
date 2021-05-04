using System.Threading.Tasks;

namespace App.Services.Notification
{
    public interface INotificationService
    {
        //Task<bool> AddNotification(Database.Models.Notification notification);
        Task<bool> FormNotification(string sender, string action, string link);
    }
}