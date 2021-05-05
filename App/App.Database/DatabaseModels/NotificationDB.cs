using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class NotificationDB
    {
        public int Id { get; set; } 
        public string Text { get; set; }
        public string Link { get; set; }
        public List<UserDB> Recievers { get; set; }
       
    }
}