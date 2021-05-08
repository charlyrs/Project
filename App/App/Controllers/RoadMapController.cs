using System.Threading.Tasks;
using App.Database.Models;
using App.Database.Project;
using App.Database.RoadMap;
using App.Services;
using App.Services.Project;
using App.Services.RoadMap;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class RoadMapController : Controller
    {
        private readonly IRoadMapService _roadMapService;
        private readonly IProjectService _projectService;

        public RoadMapController(IProjectService projectService, IRoadMapService roadMapService)
        {
            _roadMapService = roadMapService;
            _projectService = projectService;
        }
        public async Task<IActionResult> Index()
        {
            var id = CurrentProjectService.currentProjectId;
            var project = await _projectService.GetProjectByIdWithAllFields(id);
            var model = new RoadMapViewModel()
            {
                Steps = project.RoadMap.Steps
            };
            return View(model);
        }

        public async Task<IActionResult> AddStep(string title)
        {
            var step = new RMStep()
            {
                Title = title,
                RoadMap = await _projectService.GetRoadMap(CurrentProjectService.currentProjectId)
            };
            await _roadMapService.AddStep(step);
            return RedirectToAction("Index");

        }
    }
}