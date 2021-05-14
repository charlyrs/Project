using System;
using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class ProjectTaskDB
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public  List<UserDB> AssignedUsers { get; set; }
        public RMStepDB RmStep { get; set; }
        public ColumnDB Column { get; set; }
        public List<TagDB> Tags { get; set; }
        public List<CommentDB> Comments { get; set; }
        public ProjectDB Project { get; set; }
    }
}