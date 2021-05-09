using System.Threading.Tasks;
using App.Database.RoadMap;
using App.Services.RoadMap;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RoadMapTasksController : Controller
    {
        private readonly IRoadMapService _roadMapService;

        public RoadMapTasksController(IRoadMapService roadMapService)
        {
            _roadMapService = roadMapService;
        }
        public async Task<IActionResult> Index(int stepId)
        {
            var step = await _roadMapService.GetStepByIdWithTasks(stepId);
            var model = new RMStepViewModel()
            {
                Title = step.Title,
                Tasks = step.LinkedTasks
            };
            return View(model);
        }
    }
}