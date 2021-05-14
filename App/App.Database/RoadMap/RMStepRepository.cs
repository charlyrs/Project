using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.RoadMap
{
    public class RMStepRepository : IRMStepRepository
    {
        private readonly ApplicationContext _databaseContext;

        public RMStepRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<int> AddStep(RMStep step)
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
            return dbStep.Id;
        }

        public async Task<RMStep> GetStepById(int id)
        {
            var step = await _databaseContext.RoadMapSteps.Include(s => s.LinkedTasks).FirstOrDefaultAsync(s => s.Id == id);
            var result = new RMStep()
            {
                Id = step.Id,
                Title = step.Title,
                LinkedTasks = step.LinkedTasks.Select(t => new ProjectTask()
                {
                    Id = t.Id,
                    Title = t.Title
                }).ToList()
            };
            return result;
        }
    }
}