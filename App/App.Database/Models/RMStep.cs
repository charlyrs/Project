using System.Collections.Generic;

namespace App.Database.Models
{
    public class RMStep
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        
        public RoadMap RoadMap { get; set; }
        public List<ProjectTask> LinkedTasks { get; set; }
    }
}