using System.Threading.Tasks;
using App.Database.Column;
using App.Database.Models;

namespace App.Services
{
    public class ColumnService : IColumnService
    {
        private readonly IColumnRepository _columnRepository;
        public ColumnService(IColumnRepository columnRepository)
        {
            _columnRepository = columnRepository;
        }
        public async Task<Column> GetColumnById(int id)
        {
            var column = await  _columnRepository.GetColumnById(id);
            column.Tasks = await _columnRepository.GetColumnTasks(id);
            column.Project = await _columnRepository.GetColumnsProject(id);
            return column;

        }

        public async Task<bool> AddTaskToColumn(ProjectTask task, int columnId)
        {
            await _columnRepository.AddTaskToColumn(task, columnId);
            return true;
        }
    }
}