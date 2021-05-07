using System.Collections.Generic;
using App.Database.DatabaseModels;

namespace App.Database.Models
{
    public class RoadMap
    {
        public int Id { get; set; }
        
        public List<RMStep> Steps { get; set; }
        public Project Project { get; set; }
    }
}