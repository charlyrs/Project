using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.Column
{
    public interface IColumnRepository
    {
        Task<List<ProjectTask>> GetColumnTasks(int columnId);
        Task<int> AddColumn(Models.Column column);
        Task<Models.Column> GetColumnById(int id);
        Task<bool> AddTaskToColumn(ProjectTask task, int columnId);
        Task<Models.Project> GetColumnsProject(int columnId);
    }
}