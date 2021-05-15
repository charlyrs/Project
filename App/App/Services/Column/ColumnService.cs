using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq.Expressions;
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
            if (id < 1 || column == null) throw new Exception("There is no such column");
            column.Tasks = await _columnRepository.GetColumnTasks(id);
            column.Project = await _columnRepository.GetColumnsProject(id);
            return column;
        }

        public async Task<bool> AddTaskToColumn(ProjectTask task, int columnId)
        {
            if (task == null) throw new Exception("Task can not be null");
            await _columnRepository.AddTaskToColumn(task, columnId);
            return true;
        }
    }
}