using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;

namespace App.Database.RoadMap
{
    public class RMStepRepository : IRMStepRepository
    {
        private readonly ApplicationContext _databaseContext;

        public RMStepRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<bool> AddStep(RMStep step)
        {
            var rm =  await _databaseContext.RoadMaps.FindAsync(step.RoadMap.Id);
            var dbStep = new RMStepDB()
            {
                LinkedTasks = new List<ProjectTaskDB>(),
                RoadMap = rm,
                Title = step.Title
            };
            await _databaseContext.RoadMapSteps.AddAsync(dbStep);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}