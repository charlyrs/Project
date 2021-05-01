using System.Collections.Generic;

namespace App.Database.DatabaseModels
{
    public class ProjectDB
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public  List<UserDB> Users { get; set; }
        public List<ColumnDB> Columns { get; set; }
    }
}