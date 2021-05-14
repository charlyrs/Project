using System.Threading.Tasks;
using App.Database.Models;

namespace App.Services.RoadMap
{
    public interface IRoadMapService
    {
        Task<int> AddStep(RMStep step);
        Task<RMStep> GetStepByIdWithTasks(int id);
    }
}