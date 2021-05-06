using System;
using System.Threading.Tasks;
using App.Database.Column;
using App.Database.Models;
using App.Database.Task;
using App.Services;
using App.Services.Task;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class AddTaskController : Controller
    {
        private static int _columnId;
        private readonly IColumnService _columnService;
        private readonly ITaskService _taskService;

        public AddTaskController(IColumnService columnService)
        {
            _columnService = columnService;
        }
        public async Task<IActionResult> Index(int columnId)
        {
            _columnId = columnId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string title, int columnId)
        {
            _columnId = columnId;
            var task = new ProjectTask()
            {
                Title = title,
                //Deadline = deadline,
            };
            await _columnService.AddTaskToColumn(task, _columnId);
            var column = await _columnService.GetColumnById(_columnId);
            return RedirectToAction("Index", "ProjectView", new{projectId = column.Project.Id });

        }
    }
}