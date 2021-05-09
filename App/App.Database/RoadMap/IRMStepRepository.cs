using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.RoadMap
{
    public interface IRMStepRepository
    {
        Task<bool> AddStep(RMStep step);
        Task<RMStep> GetStepById(int id);
    }
}