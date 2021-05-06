using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class UserViewModel
    {
        public string Email { get; set; }
        
        public string Nickname { get; set; }
        public  List<Project> Projects { get; set; }
        public List<ProjectTask> AssignedTasks { get; set; }
        public List<Notification> Notifications { get; set; }

        public UserViewModel(User user)
        {
            Email = user.Email;
            Nickname = user.Nickname;
            Projects = user.Projects;
            AssignedTasks = user.AssignedTasks;
            Notifications = user.Notifications;

        }
    }
}