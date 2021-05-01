using System.Net.Http;
using System.Threading.Tasks;
using App.Database.Project;
using App.Database.User;
using App.Services.User;

namespace App.Services.Project
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICheckInputService _checkInputService;

        public ProjectService(IProjectRepository projectRepository, ICheckInputService checkInputService )
        {
            _projectRepository = projectRepository;
            
            _checkInputService = checkInputService;
        }

        public async Task<int> AddProject(Database.Models.Project project)
        {
            var id = await _projectRepository.AddProjectAsync(project);
            //await _projectRepository.AddDefaultColumnsToProject(id);
            await _projectRepository.AddUserToProjectAsync(CurrentUserService.currentUserId, id);
            return id;
        }

        public async Task<Database.Models.Project> GetProjectById(int id)
        {
            var project = await _projectRepository.GetProjectByIdAsync(id);
            project.Users = await _projectRepository.GetUsers(project);
            project.Columns = await _projectRepository.GetColumns(id);
            return project;
        }

        public async Task<bool> AddUserToProject(Database.Models.User user, Database.Models.Project project)
        {
            await _projectRepository.AddUserToProjectAsync(user.Id, project.Id);
            return true;
        }

        public async Task<bool> RemoveProjectFromTheUser(int projectId, int userId)
        {
            await _projectRepository.RemoveProjectFromUser(projectId, userId);
            return true;

        }
    }
}