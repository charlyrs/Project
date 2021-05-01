using System.Threading.Tasks;
using App.Database.Models;

namespace App.Services
{
    public interface IColumnService
    {
        Task<Column> GetColumnById(int id);
        Task<bool> AddTaskToColumn(ProjectTask task, int columnId);
    }
}