using System.Threading.Tasks;
using App.Database.DatabaseModels;

namespace App.Database.Notification
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationContext _databaseContext;

        public NotificationRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<bool> AddNotification(Models.Notification notification)
        {
            var dbModel = new NotificationDB()
            {
                Link = notification.Link,
                Id = notification.Id,
                Text = notification.Text
            };
            await _databaseContext.Notifications.AddAsync(dbModel);
            await _databaseContext.SaveChangesAsync();
            return true;

        }
    }
}