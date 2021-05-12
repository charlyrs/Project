using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class TasksListViewModel
    {
        public List<ProjectTask> Tasks { get; set; }
    }
}