using System.Collections.Generic;
using System.ComponentModel;

namespace App.Database.DatabaseModels
{
    public class ColumnDB
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ProjectDB Project { get; set; }
        
        public List<ProjectTaskDB> Tasks { get; set; }
        
    }
}