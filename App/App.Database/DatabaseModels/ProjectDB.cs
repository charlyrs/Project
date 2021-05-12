using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Database.DatabaseModels
{
    public class ProjectDB
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        
        public List<ColumnDB> Columns { get; set; }
        public RoadMapDB RoadMap { get; set; }
        public List<TagDB> Tags { get; set; }
        
        [InverseProperty("BossProjects")]
        public List<UserDB> BossUsers { get; set; }
        
        [InverseProperty("Projects")]
        public  List<UserDB> Users { get; set; }
        
    }
}