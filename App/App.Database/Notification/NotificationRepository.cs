using System.Collections.Generic;
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

        public  async Task<bool> RemoveNotificationFromUser(int userId, int noteId)
        {
            var user = await _databaseContext.Users.Include(u => u.Notifications).FirstOrDefaultAsync(u=>u.Id==userId);
            var note = await _databaseContext.Notifications.Include(n =>n.Recievers).FirstOrDefaultAsync(n => n.Id==noteId);
            user.Notifications.Remove(note);
            if (note.Recievers.Count == 1)
            {
                await DeleteNotification(noteId);
            }
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteNotification(int id)
        {
            var note = await _databaseContext.Notifications.FindAsync(id);
            _databaseContext.Notifications.Remove(note);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<int>> GetUsersNotificationsId(int userId)
        {
            var user = await _databaseContext.Users.Include(u => u.Notifications).FirstOrDefaultAsync(u=>u.Id==userId);
            var noteIds = user.Notifications.Select(n => n.Id).ToList();
            return noteIds;
        }
    }
}