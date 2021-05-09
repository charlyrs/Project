using System.Threading.Tasks;
using App.Database.Models;
using App.Database.RoadMap;

namespace App.Services.RoadMap
{
    public class RoadMapService : IRoadMapService
    {
        private readonly IRoadMapRepository _roadMapRepository;
        private readonly IRMStepRepository _stepRepository;

        public RoadMapService(IRoadMapRepository roadMapRepository, IRMStepRepository stepRepository)
        {
            _roadMapRepository = roadMapRepository;
            _stepRepository = stepRepository;
        }
        public async Task<bool> AddStep(RMStep step)
        {
            await _stepRepository.AddStep(step);
            return true;
        }

        public async Task<RMStep> GetStepByIdWithTasks(int id)
        {
            var step = await _stepRepository.GetStepById(id);
            return step;
        }
    }
}