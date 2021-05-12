using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Database.DatabaseModels;
using App.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Database.Tag
{
    public class TagRepository:ITagRepository
    {
        private readonly ApplicationContext _databaseContext;

        public TagRepository(ApplicationContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public  async Task<int> AddTag(Models.Tag tag)
        {
            var project = await _databaseContext.Projects.FindAsync(tag.Project.Id);
            var dbTag = new TagDB()
            {
                Project = project,
                Tasks = new List<ProjectTaskDB>(),
                Text = tag.Text
            };
            await _databaseContext.Tags.AddAsync(dbTag);
            await _databaseContext.SaveChangesAsync();
            return dbTag.Id;
        }

        public async Task<bool> AddTagToTask(int tagId, int taskId)
        {
            var tag = await _databaseContext.Tags.FindAsync(tagId);
            var task = await _databaseContext.Tasks.Include(t => t.Tags).FirstOrDefaultAsync(t => t.Id == taskId);
            task.Tags.Add(tag);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<Models.Tag> GetTagByIdWithTasks(int id)
        {
            var tag = await _databaseContext.Tags.Include(t => t.Tasks).FirstOrDefaultAsync(t => t.Id == id);
            var result = new Models.Tag()
            {
                Id = tag.Id,
                Text = tag.Text,
                Tasks = tag.Tasks.Select(task => new ProjectTask()
                {
                    Id = task.Id,
                    Title = task.Title
                }).ToList()

            };
            return result;
        }
    }
}