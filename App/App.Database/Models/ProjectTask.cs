using System;
using System.Collections.Generic;
using App.Database.DatabaseModels;

namespace App.Database.Models
{
    public class ProjectTask
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public  List<User> AssignedUsers { get; set; }
        public Column Column { get; set; }
        public RMStep RmStep { get; set; }

    }
}