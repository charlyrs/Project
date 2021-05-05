using System.Collections.Generic;
using App.Database.DatabaseModels;

namespace App.Database.Models
{
    public class Notification
    {
        public int Id { get; set; } 
        public string Text { get; set; }
        public string Link { get; set; }
        public List<UserDB> Recievers { get; set; }
    }
}