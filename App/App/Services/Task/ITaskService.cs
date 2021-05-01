using System.Threading.Tasks;
using App.Database.Models;

namespace App.Services.Task
{
    public interface ITaskService
    {
        Task<int> AddTask(ProjectTask task);
    }
}