using System.Collections.Generic;


namespace App.Database.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        public  List<User> Users { get; set; }
        public List<Column> Columns { get; set; }
        public RoadMap RoadMap { get; set; }
        public List<Tag> Tags { get; set; }
        
    }
}