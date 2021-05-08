using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.RoadMap
{
    public class RoadMapRepository : IRoadMapRepository
    {
        public readonly ApplicationContext _databaseContext;

        public RoadMapRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<List<RMStep>> GetSteps(int rmId)
        {
            var steps = _databaseContext.RoadMapSteps.Where(r => r.RoadMap.Id == rmId).Include(r => r.LinkedTasks);
            var result = await steps.ToListAsync();
            var list = result.Select(s => new RMStep()
            {
                Id = s.Id,
                Title = s.Title,
                LinkedTasks = s.LinkedTasks.Select( t => new ProjectTask()
                {
                    Id = t.Id,
                    Deadline = t.Deadline,
                    Title = t.Title
                }).ToList()
            }).ToList();
            return list;
        }
    }
}