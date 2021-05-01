using System.Collections.Generic;

namespace App.Database.Models
{
    public class Column
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Project Project { get; set; }
        public List<ProjectTask> Tasks { get; set; }
    }
}