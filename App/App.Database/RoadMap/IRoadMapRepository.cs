using System.Collections.Generic;
using System.Threading.Tasks;
using App.Database.Models;

namespace App.Database.RoadMap
{
    public interface IRoadMapRepository
    {
        Task<List<RMStep>> GetSteps(int rmId);
        
    }
}