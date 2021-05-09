using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class UserDB
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string Nickname { get; set; }
        public  List<ProjectDB> Projects { get; set; }
        public List<ProjectTaskDB> AssignedTasks { get; set; }
        public List<NotificationDB> Notifications { get; set; }
        //Not used in system
        public List<BossRoleDB> Roles { get; set; }
       
    }
}