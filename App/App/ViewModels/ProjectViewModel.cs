using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class ProjectViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        
        public  List<User> Users { get; set; }
        public List<Column> Columns { get; set; }
        
        public bool BossRole { get; set; }

        public ProjectViewModel(Project project)
        {
            Title = project.Title;
            Description = project.Description;
            Users = project.Users;
            Columns = project.Columns;
        }
    }
}