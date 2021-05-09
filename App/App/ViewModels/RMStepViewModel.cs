using System.Collections.Generic;
using App.Database.Models;

namespace App.ViewModels
{
    public class RMStepViewModel
    {
        public string Title { get; set; }
        public List<ProjectTask> Tasks { get; set; }
    }
}