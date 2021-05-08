using System;
using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class TaskViewModel
    {
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public  List<User> AssignedUsers { get; set; }
        public Column Column { get; set; }
        public RMStep RmStep { get; set; }
        public List<Tag> Tags { get; set; }

        public TaskViewModel(ProjectTask task)
        {
            Title = task.Title;
            Deadline = task.Deadline;
            AssignedUsers = task.AssignedUsers;
            Column = task.Column;
            RmStep = task.RmStep;
            Tags = task.Tags;
        }
    }
}