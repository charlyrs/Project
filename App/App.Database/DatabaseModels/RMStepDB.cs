using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class RMStepDB
    {
        public int Id { get; set; } 
        public RoadMapDB RoadMap { get; set; }
        public List<ProjectTaskDB> LinkedTasks { get; set; }
    }
}