using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class TagDB
    {
        public int Id { get; set; }
        public ProjectDB Project { get; set; }
        public string Text { get; set; }
        public List<ProjectTaskDB> Tasks { get; set; }
    }
}