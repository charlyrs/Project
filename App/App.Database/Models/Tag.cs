using System.Collections.Generic;

namespace App.Database.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public string Text { get; set; }
        public List<ProjectTask> Tasks { get; set; }
    }
}