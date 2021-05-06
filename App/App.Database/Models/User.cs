using System.Collections.Generic;

namespace App.Database.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public string Nickname { get; set; }
        public  List<Project> Projects { get; set; }
        public List<ProjectTask> AssignedTasks { get; set; }
        public List<Notification> Notifications { get; set; }

    }
}