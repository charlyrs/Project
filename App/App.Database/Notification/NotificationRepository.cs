using System.Linq;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Notification
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ApplicationContext _databaseContext;

        public NotificationRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<int> AddNotification(Models.Notification notification)
        {
            var dbModel = new NotificationDB()
            {
                Link = notification.Link,
                Id = notification.Id,
                Text = notification.Text,
                
            };
            await _databaseContext.Notifications.AddAsync(dbModel);
            await _databaseContext.SaveChangesAsync();
            return dbModel.Id;
        }

        public async Task<bool> AddNotificationToUser(int userId, int noteId)
        {
            var user = await _databaseContext.Users.Include(u => u.Notifications)
                .FirstOrDefaultAsync(u => u.Id == userId);
            var notification = await _databaseContext.Notifications.FindAsync(noteId);
            user.Notifications.Add(notification);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}