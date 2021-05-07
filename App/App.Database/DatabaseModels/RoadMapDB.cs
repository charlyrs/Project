using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class RoadMapDB
    {
        public int Id { get; set; } 
        public List<RMStepDB> Steps { get; set; }
        public ProjectDB Project { get; set; }
        public int ProjectDBId { get; set; }
        
    }
}