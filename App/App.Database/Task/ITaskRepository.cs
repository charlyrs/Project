using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.Task
{
    public interface ITaskRepository
    {
        Task<int> AddTask(ProjectTask task);
    
    }
}