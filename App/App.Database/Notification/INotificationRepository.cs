using System.Threading.Tasks;

namespace App.Database.Notification
{
    public interface INotificationRepository
    {

        public Task<bool> AddNotification(Models.Notification notification);
    }
}