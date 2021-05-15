using System;
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
        public async Task<int> AddStep(RMStep step)
        {
            if (string.IsNullOrEmpty(step.Title)) throw new Exception("Step title can't be empty");
            var id = await _stepRepository.AddStep(step);
            return id;
        }

        public async Task<RMStep> GetStepByIdWithTasks(int id)
        {
            var step = await _stepRepository.GetStepById(id);
            if (step == null) throw new Exception("There is no such roadmap step");
            return step;
        }
    }
}